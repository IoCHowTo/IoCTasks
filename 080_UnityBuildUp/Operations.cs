namespace UnityBuildUp
{
    public interface IOperation
    {
        int Evaluate(int a, int b);
    }

    /// <summary>
    /// This interface does not make much sense for "+" operation
    /// as implementing it is fairly easy. However, it would make
    /// it easy for us in the future to replace <see cref="Plus"/>
    /// with other implementation of the same functionality.
    /// </summary>
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