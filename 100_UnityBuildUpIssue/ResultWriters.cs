using System;
using System.IO;
using Microsoft.Practices.Unity;

namespace UnityBuildUpIssue
{
    public interface IConsoleResultWriter
    {
        void WriteResult(int value);
    }

    public interface IConsoleAndFileResultWriter
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

    public class ConsoleAndFileResultWriter : IConsoleAndFileResultWriter, IDisposable
    {
        private readonly StreamWriter _output;

        public ConsoleAndFileResultWriter(string fileName)
        {
            _output = File.CreateText(fileName);
        }

        [Dependency]
        public IConsoleResultWriter ConsoleResultWriter { get; set; }

        public void WriteResult(int value)
        {
            ConsoleResultWriter.WriteResult(value);
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