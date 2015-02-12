using System;
using System.IO;

namespace UnitTestingWithIoC
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

    public class FileResultWriter : IResultWriter
    {
        public void WriteResult(int value)
        {
            using (var output = File.AppendText("output.txt"))
            {
                output.WriteLine(value);
            }
        }
    }

}