using Microsoft.Practices.Unity;

namespace UnityRecursiveRegistrationIssue
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
            unityContainer
                .RegisterType<IResultWriter, ConsolidatedResultWriter>(new ContainerControlledLifetimeManager())
                .RegisterType<IResultWriterPolicy, ConsoleResultWriter>("ConsoleResultWriter")
                .RegisterType<IResultWriterPolicy, FileResultWriter>("FileResultWriter")
                .RegisterType<IResultWriterPolicy, LogResultWriter>("LogResultWriter")
                .RegisterType<ICalculator, Calculator>()
                .RegisterType<IOperationFactory, OperationFactory>()
                .RegisterType<IOperation, Plus>("+");
        }
    }

}