
// Polymorphism
class Derived : Base
{
    public new string Field1 { get; set; } = "Aloha";
    public override void Show()
    {
        Console.WriteLine("Derived class Show()");
    }
    public void Print()
    {
        Console.WriteLine("Derived class Print()");
    }
}
