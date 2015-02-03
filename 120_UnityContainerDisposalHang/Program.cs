using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace UnityContainerDisposalHang
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
                
                PerformCalculation(args, container);
                PerformCalculation(args, container);
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
