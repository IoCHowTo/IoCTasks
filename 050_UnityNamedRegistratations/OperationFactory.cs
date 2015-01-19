using Microsoft.Practices.Unity;

namespace UnityNamedRegistratations
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
            // TODO: Use the resolution via the named strategy
            // TODO: Keep in mind handling of unknown tokens
            return _container.Resolve<IOperation>(token);
        }
    }
}