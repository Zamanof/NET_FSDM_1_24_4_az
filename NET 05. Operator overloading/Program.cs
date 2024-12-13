// operator overloading

Point point = new(25, 3);
Point point2 = new(13, 36);
////Console.WriteLine(-point);
//Console.WriteLine(point + point2);
//Console.WriteLine(point - point2);
//point--;
//Console.WriteLine(point);
//Console.WriteLine(point * 3);
Console.WriteLine(3 * point);
class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public Point()
    {
        X = default;
        Y = default;
    }
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    // operator overloading
    // Unary operators overloading
    public static Point operator -(Point p)
    {
        return new(-p.X, -p.Y);
    }
    public static Point operator ++(Point p)
    {
        p.X++;
        p.Y++;
        return p;
    }
    public static Point operator --(Point p)
    {
        p.X--;
        p.Y--;
        return p;
    }

    // Binary operators overloading
    public static Point operator +(Point left, Point right)
    {
        return new Point
        {
            X= left.X + right.X,
            Y= left.Y + right.Y
        };
    }

    public static double operator -(Point left, Point right)
    {
        Point tmp = new Point(left.X, right.Y);

        return Math.Sqrt(Math.Pow((left.Y - tmp.Y), 2.0) + Math.Pow((right.X - tmp.X), 2.0));  
    }

    public static Point operator *(Point p, int value)
    {
        return new Point { X = p.X * value, Y = p.Y * value };
    }

    public static Point operator *(int value, Point p)
    {
        return new Point { X = p.X * value, Y = p.Y * value };
    }


    public override string ToString()
    {
        return $"Point(X:{X}, Y:{Y})";
    }
}
