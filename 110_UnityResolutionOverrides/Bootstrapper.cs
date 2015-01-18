using Microsoft.Practices.Unity;

namespace UnityResolutionOverrides
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
                .RegisterType<IConsoleResultWriter, ConsoleResultWriter>()
                .RegisterType<IConsoleAndFileResultWriter, ConsoleAndFileResultWriter>()
                .RegisterType<ICalculator, Calculator>()
                .RegisterType<IOperationFactory, OperationFactory>()
                .RegisterType<IOperationPlus, Plus>();
        }
    }

}