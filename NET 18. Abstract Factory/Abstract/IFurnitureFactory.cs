namespace NET_18._Abstract_Factory.Abstract;

internal interface IFurnitureFactory
{
    IChair CreateChair();
    ICoffeeTable CreateCoffeeTable();
    ISofa CreateSofa();
}
