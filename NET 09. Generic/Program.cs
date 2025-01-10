// Generic
/*
 - Class
 - Struct
 - Method
 - Interface
 - Delegate
 - Collections   
 */

//Some<int> some = new Some<int>();
//some.Foo();
//some.Bar("Salam", 23.6);
//Console.WriteLine(some.Bar("Ji", 63).GetType());

using System.Collections;

Some<List<int>> some = new();
class Some<T> where T : class, IEnumerable<int>, new()
{
    public T Value { get; set; }
    public void Foo()
    {
        Console.WriteLine(Value.GetType());
    }

    public T2 Bar<T2, T3>(T2 value1, T3 value2)
    {
        Console.WriteLine(value1.GetType());
        Console.WriteLine(value2.GetType());
        return value1;
    }
}
