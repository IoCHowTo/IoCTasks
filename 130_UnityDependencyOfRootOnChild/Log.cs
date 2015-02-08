using System;
using System.IO;

namespace UnityDependencyOfRootOnChild
{
    /// <summary>
    /// Logging service interface
    /// </summary>
    public interface ILog
    {
        /// <summary>
        /// Write an information level message into the log.
        /// </summary>
        /// <param name="message">Message including formatting.</param>
        /// <param name="values">Paramters</param>
        void Info(string message, params object[] values);
    }

    /// <summary>
    /// An implementation of logging service
    /// </summary>
    public class Log : ILog, IDisposable
    {
        private readonly StreamWriter _stream;
        private bool _isDisposed;

        public Log(string fileName)
        {
            _stream = new StreamWriter(fileName, true);
        }

        public void Info(string message, params object[] values)
        {
            if (_isDisposed) throw new ObjectDisposedException("Log");

            _stream.Write("[INFO] ");
            _stream.WriteLine(message, values);
            _stream.Flush();
        }

        public void Dispose()
        {
            if (_isDisposed)
            {
                _isDisposed = true;
                _stream.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}