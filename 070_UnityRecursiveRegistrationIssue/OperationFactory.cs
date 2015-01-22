using System;
using Microsoft.Practices.Unity;

namespace UnityRecursiveRegistrationIssue
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
            // let's validate the input here
            if (!_container.IsRegistered<IOperation>(token))
            {
                throw new InvalidOperationException("Unsupported operation " + token);
            }

            return _container.Resolve<IOperation>(token);
        }
    }
}