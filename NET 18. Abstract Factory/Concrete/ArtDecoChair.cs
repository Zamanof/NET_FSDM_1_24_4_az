namespace NET_18._Abstract_Factory.Concrete;

internal class ArtDecoChair : IChair
{
    public ArtDecoChair()
    {
        Console.WriteLine("ArtDeco Chair");
    }

    public bool HasLegs()=> false;
    public bool SitOn()=> true;
}
