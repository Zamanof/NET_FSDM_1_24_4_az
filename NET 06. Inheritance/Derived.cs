// inheritance
class Derived : Base
{
    public string SomeProperty {  get; set; }
    public Derived()
        :this(string.Empty, 0, 0)
    {
        SomeProperty = "Salam";
        Console.WriteLine("Derived class Default Constructor");
    }
    public Derived(string some, int field1, int field2)
        :base(field1, field2)
    {
        SomeProperty = some;
        Console.WriteLine("Derived class Parametrized Constructor");
    }

    public void DerivedFoo()
    {
        base.Foo();
    }

    public new void Foo()
    {
        Console.WriteLine("Derived Foo");
    }
    public new void Show()
    {
        Console.WriteLine("Derived Show()");
        //base.Show();
        Console.WriteLine($"SomeProperty = {SomeProperty}");
    }



}