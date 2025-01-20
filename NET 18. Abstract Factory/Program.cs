using NET_18._Abstract_Factory.Abstract;
using NET_18._Abstract_Factory.Concrete;

IFurnitureFactory furnitureFactory = new ModernFurnitureFactory();
furnitureFactory.CreateChair();
furnitureFactory.CreateCoffeeTable();
furnitureFactory.CreateSofa();

