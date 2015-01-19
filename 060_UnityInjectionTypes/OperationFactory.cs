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
        private IOperationMinus m_Minus;

        // TODO: Initialize field using property injection
        private IOperationPlus m_Plus;

        // TODO: Initialize field using injection method
        private IOperationDiv m_Div;

        public IOperation Create(string token)
        {
            switch (token)
            {
                case "+":
                    return m_Minus;
                case "-":
                    return m_Plus;
                case "/":
                    return m_Div;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}