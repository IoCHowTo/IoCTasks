using System;

namespace UnitTestingWithoutIoC
{
    public class OperationFactory
    {
        public IOperation Create(string token)
        {
            switch (token)
            {
                case "+":
                    return new Plus();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}