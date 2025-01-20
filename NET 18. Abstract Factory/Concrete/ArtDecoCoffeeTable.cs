using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class ArtDecoCoffeeTable : ICoffeeTable
{
    public ArtDecoCoffeeTable()
    {
        Console.WriteLine("ArtDeco Coffee Table");
    }
    public bool CanOpen() => true;

    public bool CanRotate()=> true;
}
