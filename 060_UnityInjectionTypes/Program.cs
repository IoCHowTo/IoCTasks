using Microsoft.Practices.Unity;

namespace UnityInjectionTypes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                args = new[] { "10", "-", "20", "+", "30", "/", "2" };
            }

            using (var container = new UnityContainer())
            {
                Bootstrapper.SetupContainer(container);

                var calculator = container.Resolve<ICalculator>();
                int result = calculator.Evaluate(args);

                var resultWriter = container.Resolve<IResultWriter>();
                resultWriter.WriteResult(result);
            }
        }
    }
}
