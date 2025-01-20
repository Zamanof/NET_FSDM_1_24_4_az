namespace NET_18._Abstract_Factory.Concrete;

internal class ModernChair : IChair
{
    public ModernChair()
    {
        Console.WriteLine("Modern Chair");
    }

    public bool HasLegs() => false;

    public bool SitOn()=> false;
}
