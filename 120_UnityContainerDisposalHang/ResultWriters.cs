using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace UnityContainerDisposalHang
{
    /// <summary>
    /// An interface for result writing service
    /// </summary>
    public interface IResultWriter
    {
        /// <summary>
        /// Writes the given value into results
        /// </summary>
        /// <param name="value">Value to be written into result</param>
        void WriteResult(int value);
    }

    /// <summary>
    /// This implementes a file writer being performed on a background thread.
    /// Thread is expected to be properly shutdown during disposal
    /// </summary>
    public class BackgroundFileResultWriter : IResultWriter, IDisposable
    {
        private readonly Thread _thread;
        private readonly ManualResetEvent _shutdown = new ManualResetEvent(false);
        private readonly AutoResetEvent _notifier = new AutoResetEvent(false);
        private Queue<int> _values = new Queue<int>();
        private readonly object _lock = new object();

        public BackgroundFileResultWriter()
        {
            _thread = new Thread(BackgroundWriter);
            _thread.Start();
        }

        public void WriteResult(int value)
        {
            lock (_lock)
            {
                _values.Enqueue(value);
                _notifier.Set();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                _shutdown.Set();
                _thread.Join();
            }
        }

        private void BackgroundWriter()
        {
            while (_notifier.WaitOne())
            {
                lock (_lock)
                {
                    while (_values.Count != 0)
                    {
                        var value = _values.Dequeue();
                        using (var file = File.AppendText("output.txt"))
                        {
                            file.WriteLine("Result: {0}", value);
                        }
                    }
                }
            }
        }

    }
}