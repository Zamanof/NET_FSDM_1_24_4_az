using NET_18._Abstract_Factory.Abstract;
namespace NET_18._Abstract_Factory.Concrete;

internal class ModernCoffeeTable : ICoffeeTable
{
    public ModernCoffeeTable()
    {
        Console.WriteLine("Modern Coffee Table");
    }
    public bool CanOpen()=> false;

    public bool CanRotate()=> false;
}
