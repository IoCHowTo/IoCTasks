using System;
using Microsoft.Practices.Unity;

namespace UnityLifetimeManagement
{
    public interface IOperationFactory
    {
        IOperation Create(string token);
    }

    public class OperationFactory : IOperationFactory
    {
        private readonly IUnityContainer _container;

        public OperationFactory(IUnityContainer container)
        {
            _container = container;
        }

        public IOperation Create(string token)
        {
            switch (token)
            {
                case "+":
                    return _container.Resolve<IOperationPlus>();
                case "-":
                    // return _container.Resolve<IOperationMinus>();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}