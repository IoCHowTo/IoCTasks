using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace UnityLifetimeManagement
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

                using (var childContainer = container.CreateChildContainer())
                {
                    Bootstrapper.SetupChildContainer(childContainer);

                    PerformCalculationAndWriteResult(args, childContainer);
                }

                using (var childContainer = container.CreateChildContainer())
                {
                    Bootstrapper.SetupChildContainer(childContainer);

                    PerformCalculationAndWriteResult(args, childContainer);
                }
            }
        }

        private static void PerformCalculationAndWriteResult(IEnumerable<string> args, IUnityContainer childContainer)
        {
            var calculator = childContainer.Resolve<ICalculator>();
            int result = calculator.Evaluate(args);

            var resultWriter = childContainer.Resolve<IResultWriter>();
            resultWriter.WriteResult(result);
        }
    }
}
