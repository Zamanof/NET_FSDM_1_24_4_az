using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
        => new VictorianChair();

    public ICoffeeTable CreateCoffeeTable()
        =>new VictorianCoffeeTable();

    public ISofa CreateSofa()
        => new VictorianSofa();
}
