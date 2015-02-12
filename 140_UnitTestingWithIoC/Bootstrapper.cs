using Microsoft.Practices.Unity;

namespace UnitTestingWithIoC
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
                // This is actually one of the benefits with IoC container since you can swap
                // implementations of a service very quickly just by changing the registration
                .RegisterType<IResultWriter, ConsoleResultWriter>()
                // .RegisterType<IResultWriter, FileResultWriter>()
                .RegisterType<ICalculator, Calculator>()
                .RegisterType<IOperationFactory, OperationFactory>()
                .RegisterType<IOperationPlus, Plus>()
                .RegisterType<IOperationMinus, Minus>();
        }
    }

}