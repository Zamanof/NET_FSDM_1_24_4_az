//Rectangle rectangle = new(width: 26, height: 10);
//Console.WriteLine(Calculate.Area(rectangle));
//rectangle.Width = 15;
//Console.WriteLine(Calculate.Area(rectangle));

//Rectangle square = new Square(side: 15);
//Console.WriteLine(Calculate.Area(square));
//square.Width = 10;
//Console.WriteLine(Calculate.Area(square));


#region Liskov Substitution - Bad Example
//class Rectangle
//{
//    public double Width { get; set; }
//    public double Height { get; set; }

//    public Rectangle(double width, double height)
//    {
//        Width = width;
//        Height = height;
//    }
//}

//class Square : Rectangle
//{
//    public Square(double side) : base(side, side) { }
//}

//class Calculate
//{
//    public static double Area(Rectangle rect) => rect.Width * rect.Height;
//}
#endregion

#region Liskov Substitution - Good Example

class Rectangle
{
    public virtual double Width { get; set; }
    public virtual double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
}

class Square : Rectangle
{
    public override double Width
    {
        get => base.Width;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }
    public override double Height
    {
        get => base.Height;
        set
        {
            base.Height = value;
            base.Width = value;
        }
    }


    public Square(double side) : base(side, side) { }
}

class Calculate
{
    public static double Area(Rectangle rect) => rect.Width * rect.Height;
}

#endregion