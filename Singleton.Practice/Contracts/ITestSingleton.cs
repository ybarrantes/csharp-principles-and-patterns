using Singleton.Conceptual.Contracts;

namespace Singleton.Practice.Contracts;

public interface ITestSingleton
{
    void Execute<T>(int count) where T : ISingleton;
}