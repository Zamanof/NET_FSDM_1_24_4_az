#region Open/Closed Principle Bad Example

//object[] shapes = [
//    new Rectangle() {Height = 36, Width= 13 },
//    new Rectangle() {Height = 48, Width= 23.5 },
//    new Circle(){Radius = 23.5},
//    new Rectangle() {Height = 18.7, Width= 22.5 },
//    new Traingle() {Base = 23, Height = 45}
//];

//Calculate calculate = new();
//Console.WriteLine(calculate.Areas(shapes));

//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }
//}
//class Circle
//{
//    public double Radius { get; set; }
//}

//class Traingle
//{
//    public double Height { get; set; }
//    public double Base { get; set; }
//}

//class Calculate
//{
//    public double Areas(object[] shapes)
//    {
//        double areas = 0;
//        foreach (var shape in shapes) 
//        {
//            if(shape is Rectangle rectangle)
//            {
//                areas += rectangle.Width * rectangle.Height;
//            }
//            else if (shape is Circle circle)
//            {
//                areas += Math.Pow(circle.Radius, 2) * Math.PI;
//            }
//            else if(shape is Traingle traingle)
//            {
//                areas += 0.5 * traingle.Base * traingle.Height;
//            }
//        }
//        return areas;
//    }
//}
#endregion

#region Open/Closed Principle Bad Example

Shape[] shapes = [
    new Rectangle() {Height = 36, Width= 13 },
    new Rectangle() {Height = 48, Width= 23.5 },
    new Circle(){Radius = 23.5},
    new Rectangle() {Height = 18.7, Width= 22.5 },
    new Traingle() {Base = 23, Height = 45},
    new Astobalefanter(){Amelo = -23, Filfilo = -35.3, Zenter = 2}
];

Calculate calculate = new();
Console.WriteLine(calculate.Areas(shapes));

abstract class Shape
{
    public abstract double Area();
}
class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }

    public override double Area()=> Height * Width;
}
class Circle : Shape
{
    public double Radius { get; set; }

    public override double Area() => Math.Pow(Radius, 2) * Math.PI;
}

class Traingle: Shape
{
    public double Height { get; set; }
    public double Base { get; set; }

    public override double Area() => 0.5 * Base * Height;
}

class Astobalefanter : Shape
{
    public double Amelo { get; set; }
    public double Zenter { get; set; }
    public double Filfilo { get; set; }
    public override double Area() => Amelo * Zenter/2 + Math.Sqrt(Math.Abs(Filfilo));
}

class Calculate
{
    public double Areas(Shape[] shapes) => shapes.Sum(x => x.Area());
}
#endregion
