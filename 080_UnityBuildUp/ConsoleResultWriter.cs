using System;
using System.IO;

namespace UnityBuildUp
{
    public interface IConsoleResultWriter
    {
        void WriteResult(int value);
    }
    
    /// <summary>
    /// </summary>
    public class ConsoleResultWriter : IConsoleResultWriter
    {
        public void WriteResult(int value)
        {
            Console.WriteLine(value);
        }
    }

    // TODO: Alter the constructor so you can specify a file name
    // TODO: and use technique which will allow you to use BuildUp method
    public class ConsoleAndFileResultWriter : IDisposable
    {
        private readonly IConsoleResultWriter _consoleResultWriter;
        private readonly StreamWriter _output;

        public ConsoleAndFileResultWriter(string fileName, IConsoleResultWriter consoleResultWriter)
        {
            _consoleResultWriter = consoleResultWriter;
            _output = File.CreateText(fileName);
        }

        public void WriteResult(int value)
        {
            _consoleResultWriter.WriteResult(value);
            _output.WriteLine(value);
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