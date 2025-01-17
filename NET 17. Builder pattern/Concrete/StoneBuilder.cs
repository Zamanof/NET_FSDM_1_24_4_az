using NET_17._Builder_pattern.Abstract;

namespace NET_17._Builder_pattern.Concrete;

internal class StoneBuilder : IBuilder
{
    public House House { get; set; } = new House { Name = "Stone House" };

    public IBuilder BuildDoor()
    {
        House.Door = 1;
        return this;
    }

    public IBuilder BuildGarage()
    {
        House.Garage = 1;
        return this;
    }

    public IBuilder BuildGarden()
    {
        House.Garden = 1;
        return this;
    }

    public IBuilder BuildPool()
    {
        House.Pool = 1;
        return this;
    }

    public IBuilder BuildRoof()
    {
        House.HasRoof = true;
        return this;
    }

    public IBuilder BuildWall()
    {
        House.Walls = 4;
        return this;
    }

    public IBuilder BuildWindow()
    {
        House.Window = 2;
        return this;
    }

    public House GetHouse() => House;

    public IBuilder Reset()
    {
        House = new();
        return this;
    }
}
