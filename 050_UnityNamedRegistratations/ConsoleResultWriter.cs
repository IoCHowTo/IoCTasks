using System;
using System.IO;
using Microsoft.Practices.Unity;

namespace UnityNamedRegistratations
{
    public interface IResultWriter
    {
        void WriteResult(int value);
    }

    /// <summary>
    /// </summary>
    public class ConsoleResultWriter : IResultWriter
    {
        public void WriteResult(int value)
        {
            Console.WriteLine(value);
        }
    }

    public class FileResultWriter : IResultWriter, IDisposable
    {
        private readonly StreamWriter m_Output;

        public FileResultWriter()
        {
            m_Output = File.CreateText("output.txt");
        }

        public void WriteResult(int value)
        {
            m_Output.WriteLine(value);
        }

        public void Dispose()
        {
            if (m_Output != null)
            {
                m_Output.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }

    // TODO: Adjust dependencies here to match their registrations
    // TODO: based on desired strategies
    
    /// <summary>
    /// Purpose of this class is to use both result writers
    /// to write the result into the console as well as file
    /// </summary>
    public class ConsolidatedResultWriter : IResultWriter
    {
        [Dependency]
        public IResultWriter ConsoleResultWriter { get; set; }

        [Dependency]
        public IResultWriter FileResultWriter { get; set; }

        public void WriteResult(int value)
        {
            ConsoleResultWriter.WriteResult(value);
            FileResultWriter.WriteResult(value);
        }
    }
}