using NET_17._Builder_pattern.Abstract;
using NET_17._Builder_pattern.Concrete;
// Builder pattern

// Product
// Builder
// Builder : Concrete
// Director


IBuilder builder = new StoneBuilder();

var stoneHouse = builder
                        .BuildWall()
                        .BuildWindow()
                        .BuildDoor()
                        .BuildGarage()
                        .BuildPool()
                        .GetHouse();
stoneHouse.Name = "Dash ev";
Console.WriteLine(stoneHouse);
