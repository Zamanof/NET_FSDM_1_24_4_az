
// Polymorphism
class Base
{
    public string Field1 { get; set; } = "Hello";
    public virtual void Show()
    {
        Console.WriteLine("Base class Show()");
    }

}
