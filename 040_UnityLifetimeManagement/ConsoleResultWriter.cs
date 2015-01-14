using System;
using System.IO;

namespace UnityLifetimeManagement
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
            m_Output.WriteLine("Result: {0}", value);
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
}