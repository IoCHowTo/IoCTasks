using System;

namespace IoCWithUnity
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
}