namespace Singleton.Conceptual.Impl.TestSingleton;

public class ParallelTestSingleton : AbstractTestSingleton
{
    protected override void ExecuteIterator<T>(int count)
    {
        Parallel.ForEach(Enumerable.Range(0, count), (index) =>
        {
            Console.WriteLine($"Starting thread {index}...");
            ExecuteFunc<T>(index);
        });
    }
}