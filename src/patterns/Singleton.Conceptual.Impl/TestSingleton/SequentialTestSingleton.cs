namespace Singleton.Conceptual.Impl.TestSingleton;

public class SequentialTestSingleton : AbstractTestSingleton
{
    protected override void ExecuteIterator<T>(int count)
    {
        for (var i = 0; i < count; i++)
        {
            ExecuteFunc<T>(i);
        }
    }
}