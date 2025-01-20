using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class ArtDecoFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair() => new ArtDecoChair();

    public ICoffeeTable CreateCoffeeTable()=> new ArtDecoCoffeeTable();

    public ISofa CreateSofa()=> new ArtDecoSofa();
}
