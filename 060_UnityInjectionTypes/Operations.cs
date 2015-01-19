namespace UnityInjectionTypes
{
    public interface IOperation
    {
        int Evaluate(int a, int b);
    }

    public interface IOperationPlus : IOperation
    {
    }

    public class Plus : IOperationPlus
    {
        public int Evaluate(int a, int b)
        {
            return a + b;
        }
    }

    public interface IOperationMinus : IOperation
    {
        
    }

    public class Minus : IOperationMinus
    {
        public int Evaluate(int a, int b)
        {
            return a - b;
        }
    }

    public interface IOperationDiv : IOperation
    {

    }

    public class Div : IOperationDiv
    {
        public int Evaluate(int a, int b)
        {
            return a - b;
        }
    }
}