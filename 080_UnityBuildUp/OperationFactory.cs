using System;
using Microsoft.Practices.Unity;

namespace UnityBuildUp
{
    public interface IOperationFactory
    {
        IOperation Create(string token);
    }

    public class OperationFactory : IOperationFactory
    {
        private readonly IUnityContainer m_Container;

        public OperationFactory(IUnityContainer container)
        {
            m_Container = container;
        }

        public IOperation Create(string token)
        {
            switch (token)
            {
                case "+":
                    return m_Container.Resolve<IOperationPlus>();
                case "-":
                    // return m_Container.Resolve<IOperationMinus>();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}