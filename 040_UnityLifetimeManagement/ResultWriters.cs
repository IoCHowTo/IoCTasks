using System;
using System.IO;

namespace UnityLifetimeManagement
{
    public interface IResultWriter
    {
        void WriteResult(int value);
    }

    public class ConsoleResultWriter : IResultWriter
    {
        public void WriteResult(int value)
        {
            Console.WriteLine(value);
        }
    }

    public class FileResultWriter : IResultWriter, IDisposable
    {
        private readonly StreamWriter _output;

        public FileResultWriter()
        {
            _output = File.CreateText("output.txt");
        }

        public void WriteResult(int value)
        {
            _output.WriteLine("Result: {0}", value);
        }

        public void Dispose()
        {
            if (_output != null)
            {
                _output.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}