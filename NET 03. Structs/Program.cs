// Structs

Point point = new Point(25, 156);
Console.WriteLine($"x = {point.x}, y = {point.y}");
Point point1 = point;
Console.WriteLine($"x = {point1.x}, y = {point1.y}");
point1.x = 3698;
Console.WriteLine($"x = {point.x}, y = {point.y}");


