using Singleton.Conceptual.Singleton;
using Singleton.Conceptual.Impl.TestSingleton;

Console.WriteLine("------------------------");
Console.WriteLine("starting...");
Console.WriteLine("------------------------");
Console.WriteLine();

var testSingleton = new SequentialTestSingleton();

testSingleton.Execute<NonThreadSafeSingleton>(10);
testSingleton.Execute<ThreadSafeSimpleSingleton>(10);
testSingleton.Execute<ThreadSafeDoubleCheckLockingSingleton>(10);
testSingleton.Execute<ThreadSafeLazySingleton>(10);
testSingleton.Execute<ThreadSafeNonLazyWithoutLocksSingleton>(10);