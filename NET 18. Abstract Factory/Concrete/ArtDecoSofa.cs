using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class ArtDecoSofa : ISofa
{
    public ArtDecoSofa()
    {
        Console.WriteLine("ArtDecoSofa Sofa");
    }
    public bool CanOpen() => true;

    public bool HasCorner() => true;
}
