using NET_18._Abstract_Factory.Abstract;
namespace NET_18._Abstract_Factory.Concrete;

internal class VictorianSofa : ISofa
{
    public VictorianSofa()
    {
        Console.WriteLine("Victorian Sofa");
    }
    public bool CanOpen() => false;

    public bool HasCorner() => true;
}
