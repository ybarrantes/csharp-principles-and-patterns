using Singleton.Conceptual.Contracts;

namespace Singleton.Conceptual.Impl.Contracts;

public interface ITestSingleton
{
    void Execute<T>(int count) where T : ISingleton;
}