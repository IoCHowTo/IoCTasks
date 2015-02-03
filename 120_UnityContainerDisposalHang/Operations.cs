namespace UnityContainerDisposalHang
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
}