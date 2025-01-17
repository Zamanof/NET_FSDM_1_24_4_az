namespace NET_17._Builder_pattern.Abstract;

internal interface IBuilder
{
    public House House { get; set; }
    IBuilder Reset();
    IBuilder BuildWall();
    IBuilder BuildDoor();
    IBuilder BuildWindow();
    IBuilder BuildGarage();
    IBuilder BuildGarden();
    IBuilder BuildPool();
    IBuilder BuildRoof();

    House GetHouse(); // Build

}
