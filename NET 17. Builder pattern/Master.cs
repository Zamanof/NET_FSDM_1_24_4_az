using NET_17._Builder_pattern.Abstract;

namespace NET_17._Builder_pattern;

class Master // Director
{
    private IBuilder _builder;

    public Master(IBuilder builder)
    {
        _builder = builder;
    }

    public void ChangeBuilder(IBuilder builder)
    {
        _builder = builder;
    }

    public House Make(string type)
    {
        _builder.Reset();
        switch (type)
        {
            case "A":
                _builder.House.Name = "A type House";
                return _builder
                                .BuildRoof()
                                .BuildGarden()
                                .BuildDoor()
                                .BuildWindow()
                                .BuildWall()
                                .GetHouse();
            case "B":
                _builder.House.Name = "B type House";
                return _builder
                                .BuildRoof()
                                .BuildGarden()
                                .BuildGarage()
                                .BuildDoor()
                                .BuildWindow()
                                .BuildWall()
                                .GetHouse();
            case "C":
                _builder.House.Name = "B type House";
                return _builder
                                .BuildGarden()
                                .BuildGarage()
                                .BuildPool()
                                .GetHouse();
            default: throw new Exception("Wrong House Type");
        }
    }
}
