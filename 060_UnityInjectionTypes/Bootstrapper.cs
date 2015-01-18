using Microsoft.Practices.Unity;

namespace UnityInjectionTypes
{
    public static class Bootstrapper
    {
        /// <summary>
        /// Setup method for the unity container
        /// </summary>
        public static void SetupContainer(IUnityContainer unityContainer)
        {
            unityContainer
                .RegisterType<ICalculator, Calculator>()
                .RegisterType<IOperationPlus, Plus>()
                .RegisterType<IOperationMinus, Minus>()
                .RegisterType<IOperationDiv, Div>()
                .RegisterType<IOperationFactory, OperationFactory>()
                .RegisterType<IResultWriter, ConsoleResultWriter>();
        }
    }

}