class VictorianChair : IChair
{
    public VictorianChair()
    {
        Console.WriteLine("Victorian Chair");
    }

    public bool HasLegs()=> true;

    public bool SitOn()=> true;
}
