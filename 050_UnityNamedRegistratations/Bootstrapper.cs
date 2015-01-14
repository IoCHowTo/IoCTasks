using Microsoft.Practices.Unity;

namespace UnityNamedRegistratations
{
    public static class Bootstrapper
    {
        /// <summary>
        /// Setup method for the unity container
        /// </summary>
        /// <remarks>
        /// It is good idea to extract all the registrations into a single place
        /// so it is obvious where the setup is happening.
        /// </remarks>
        /// <param name="unityContainer"></param>
        public static void SetupContainer(IUnityContainer unityContainer)
        {
            // TODO: At first fix the registrations here to get everything working using ConsoleResultWriter

            // TODO: Then change ConsoleResultWriter to ConsolidatedResultWriter and update registrations
            // TODO: here for additional dependencies
            unityContainer
                .RegisterType<IResultWriter, ConsoleResultWriter>()
                .RegisterType<ICalculator, Calculator>()
                .RegisterType<IOperationFactory, OperationFactory>()
                .RegisterType<IOperation, Plus>();
        }
    }

}