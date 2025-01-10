MyClass myClass = new MyClass();
Some(myClass);
void Some(MyClass myClass)
{
    Console.WriteLine("Some Method");
}
class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor...");
    }

    // Finalizer
    ~MyClass()
    {
        Console.WriteLine("Finalizer...");
    }
}
