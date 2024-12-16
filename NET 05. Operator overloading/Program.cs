// operator overloading

Point point = new(2, 0);
Point point2 = new(25, 3);
////Console.WriteLine(-point);
//Console.WriteLine(point + point2);
//Console.WriteLine(point - point2);
//point--;
//Console.WriteLine(point);
//Console.WriteLine(point * 3);
//Console.WriteLine(3 * point);
//Console.WriteLine(point != point2);

if (point)
{
    Console.WriteLine("Koordinat bashlanqicinda deyil");
}

else
{
    Console.WriteLine("Koordinat bashlanqicindadir");
}
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
            X = left.X + right.X,
            Y = left.Y + right.Y
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

    // comparison operators
    public override bool Equals(object? obj)
    {
        return this.ToString() == obj?.ToString();
    }
    public override int GetHashCode()
    {
        return this.ToString().GetHashCode();
    }

    public static bool operator ==(Point left, Point right)
    {
        return left.Equals(right);
    }
    public static bool operator !=(Point left, Point right)
    {
        return !(left == right);
    }

    public static bool operator >(Point left, Point right)
    {
        return Math.Sqrt(Math.Pow(left.X, 2) + Math.Pow(left.Y, 2))
            > Math.Sqrt(Math.Pow(right.X, 2) + Math.Pow(right.Y, 2));
    }

    public static bool operator <(Point left, Point right)
    {
        return Math.Sqrt(Math.Pow(left.X, 2) + Math.Pow(left.Y, 2))
            < Math.Sqrt(Math.Pow(right.X, 2) + Math.Pow(right.Y, 2));
    }

    public static bool operator true(Point point)
    {
        return point.X != 0 || point.Y != 0;
    }
    public static bool operator false(Point point)
    {
        return point.X == 0 && point.Y == 0;
    }

    public static Point operator |(Point left, Point right)
    {
        if ((left.X != 0 || left.Y != 0) || (right.X != 0 || right.Y != 0))
        {
            return right;
        }
        return new Point();
    }
    public static Point operator &(Point left, Point right)
    {
        if ((left.X != 0 && left.Y != 0) && (right.X != 0 && right.Y != 0))
        {
            return right;
        }
        return new Point();
    }

    public override string ToString()
    {
        return $"Point(X:{X}, Y:{Y})";
    }
}
