using System;
using Microsoft.Practices.Unity;

namespace UnityNamedRegistratations
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
            // TODO: Use the resolution via the named strategy
            // TODO: Keep in mind handling of unknown tokens
            return m_Container.Resolve<IOperation>(token);
        }
    }
}