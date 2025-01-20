using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class ModernSofa : ISofa
{
    public ModernSofa()
    {
        Console.WriteLine("Modern Sofa");
    }
    public bool CanOpen() => false;

    public bool HasCorner()=> false;
}
