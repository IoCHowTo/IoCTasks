using System;

namespace IoCWithoutUnity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                args = new[] { "10", "+", "20", "+", "30" };
            }

            var calculator = new Calculator();
            int result = calculator.Evaluate(args);

            Console.WriteLine(result);
        }
    }
}
