using NET_17._Builder_pattern;
using NET_17._Builder_pattern.Abstract;
using NET_17._Builder_pattern.Concrete;
using System.Text;
// Builder pattern

// Product
// Builder
// Builder : Concrete
// Director


IBuilder builder = new StoneBuilder();

//var stoneHouse = builder
//                        .BuildWall()
//                        .BuildWindow()
//                        .BuildDoor()
//                        .BuildGarage()
//                        .BuildPool()
//                        .GetHouse();
//stoneHouse.Name = "Dash ev";
//Console.WriteLine(stoneHouse);

Master master = new(builder);
House house = master.Make("B");
Console.WriteLine(house);
master.ChangeBuilder(new WoodBuilder());
house = master.Make("B");
Console.WriteLine();
Console.WriteLine(house);


