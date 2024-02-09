// See https://aka.ms/new-console-template for more information


using Singleton.Conceptual.Singleton;

Console.WriteLine("------------------------");
// Console.WriteLine("NonThreadSafeSingleton");
// Console.WriteLine("------------------------");
// NonThreadSafeSingleton.Instance.DoSomething();
// Console.WriteLine("------------------------");
Parallel.ForEach(Enumerable.Range(0, 10), _ =>
{
    SimpleThreadSafeSingleton.Instance.DoSomething();
});
Console.WriteLine();
Console.WriteLine();

// Console.WriteLine("------------------------");
// Console.WriteLine("SimpleThreadSafeSingleton");
// Console.WriteLine("------------------------");
// Parallel.ForEach(Enumerable.Range(0, 20), _ =>
// {
//     SimpleThreadSafeSingleton.Instance.DoSomething();
// });
// Console.WriteLine();
// Console.WriteLine();
//
//
// Console.WriteLine("------------------------");
// Console.WriteLine("DoubleCheckThreadSafeSingleton");
// Console.WriteLine("------------------------");
// Parallel.ForEach(Enumerable.Range(0, 10), _ =>
// {
//     DoubleCheckThreadSafeSingleton.Instance.DoSomething();
// });
// Console.WriteLine();
// Console.WriteLine();
//
// Console.WriteLine("------------------------");
// Console.WriteLine("LazySingleton");
// Console.WriteLine("------------------------");
// Parallel.ForEach(Enumerable.Range(0, 10), _ =>
// {
//     LazySingleton.Instance.DoSomething();
// });
// Console.WriteLine();
// Console.WriteLine();
