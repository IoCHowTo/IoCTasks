using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace UnityChildContainers
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
                
                // TODO: This is the place where your child container should be created, initialized
                // TODO: and PeformCalculation method should be invoked on child container instead.

                PerformCalculation(args, container);
            }
        }

        private static void PerformCalculation(IEnumerable<string> args, UnityContainer container)
        {
            var calculator = container.Resolve<ICalculator>();
            int result = calculator.Evaluate(args);

            var resultWriter = container.Resolve<IResultWriter>();
            resultWriter.WriteResult(result);
        }
    }
}
