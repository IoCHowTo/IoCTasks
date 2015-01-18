using Microsoft.Practices.Unity;

namespace UnityResolutionOverrides
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

                // TODO: Get the resolution working using various types of dependency overrides
                var resultWriter = container.Resolve<IConsoleAndFileResultWriter>();

                resultWriter.WriteResult(result);
            }
        }
    }
}
