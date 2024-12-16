// inheritance
class GrandChild : Derived
{
    public GrandChild()
        :base("Hi", 36, 48)
    {
        Console.WriteLine("GrandChild class Default Constructor");
    }

    public GrandChild(string some, int field1, int field2) 
        : base(some, field1, field2)
    {
        Console.WriteLine("GrandChild class Parametrized Constructor");
    }
    public void GrandChildFoo()
    {
        Foo();
    }

}