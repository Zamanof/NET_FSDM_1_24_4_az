using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class VictorianCoffeeTable : ICoffeeTable
{
    public VictorianCoffeeTable()
    {
        Console.WriteLine("Victorian Coffee Table");
    }
    public bool CanOpen()=> true;

    public bool CanRotate() => false;
}
