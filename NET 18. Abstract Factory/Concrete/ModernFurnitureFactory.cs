using NET_18._Abstract_Factory.Abstract;

namespace NET_18._Abstract_Factory.Concrete;

internal class ModernFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()=> new ModernChair();

    public ICoffeeTable CreateCoffeeTable()=> new ModernCoffeeTable();

    public ISofa CreateSofa()=> new ModernSofa();
}
