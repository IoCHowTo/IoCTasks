using Microsoft.Practices.Unity;

namespace UnityLifetimeManagement
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
                .RegisterType<ICalculator, Calculator>()
                .RegisterType<IOperationFactory, OperationFactory>()
                .RegisterType<IOperationPlus, Plus>();
        }
        
        /// <summary>
        /// Setup method for the unity container
        /// </summary>
        /// <remarks>
        /// It is good idea to extract all the registrations into a single place
        /// so it is obvious where the setup is happening.
        /// </remarks>
        /// <param name="unityContainer"></param>
        public static void SetupChildContainer(IUnityContainer unityContainer)
        {
            // TODO: Review the lifetime manager and consider the proper registration
            // TODO: with respect to root/child container
            unityContainer
                .RegisterType<IResultWriter, FileResultWriter>();
        }
    }

}