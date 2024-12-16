// inheritance

class Base
{
    public int Field1 { get; set; }
    private int Field2;

    public Base()
        :this(1, 2)
    {
        Console.WriteLine("Base class Default Constructor");
    }

    public Base(int field1, int field2)
    {
        Field1 = field1;
        Field2 = field2;
        Console.WriteLine("Base class Parametrized Constructor");
    }
    public void Show()
    {
        Console.WriteLine($"Base Show() Field1 = {Field1}, Field2 = {Field2}");
    }
    protected void Foo()
    {
        Console.WriteLine("Protected method Foo()");
        Bar();
    }

    private void Bar()
    {
        Console.WriteLine("Private method Bar()");
    }

}
