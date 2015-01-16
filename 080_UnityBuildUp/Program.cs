using Microsoft.Practices.Unity;

namespace UnityBuildUp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                args = new[] { "10", "+", "20", "+", "30" };
            }

            using (var container = new UnityContainer())
            {
                Bootstrapper.SetupContainer(container);

                var calculator = container.Resolve<ICalculator>();
                int result = calculator.Evaluate(args);

                // TODO: Adjust the following two lines to utilize container.BuildUp() method
                // TODO: instead of explicitely resolving IConsoleResultWriter
                // TODO: Keep in mind that you may have mutliple dependencies on ConsoleAndFileResultWriter so
                // TODO: resolving them automatically via IoC container is very convenient
                var consoleWriter = container.Resolve<IConsoleResultWriter>();
                var resultWriter = new ConsoleAndFileResultWriter("output.txt", consoleWriter);

                resultWriter.WriteResult(result);
            }
        }
    }
}
