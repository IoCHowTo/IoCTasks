using System;

namespace UnityInjectionTypes
{
    public interface IOperationFactory
    {
        IOperation Create(string token);
    }

    public class OperationFactory : IOperationFactory
    {
        // TODO: Initialize field using constructor injection
        private IOperationMinus _minus;

        // TODO: Initialize field using property injection
        private IOperationPlus _plus;

        // TODO: Initialize field using injection method
        private IOperationDiv _div;

        public IOperation Create(string token)
        {
            switch (token)
            {
                case "-":
                    return _minus;
                case "+":
                    return _plus;
                case "/":
                    return _div;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}