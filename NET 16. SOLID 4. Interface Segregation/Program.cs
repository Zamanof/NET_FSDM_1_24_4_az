#region Interface Segregation - Bad Example
//abstract class Animal
//{
//    public abstract void Feed();
//    public abstract void Groom();
//}

//class Dog : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Dog feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Dog groom");
//    }
//}

//class Cat : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Cat feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Cat groom");
//    }
//}

//class Tiger : Animal
//{
//    public override void Feed()
//    {
//        Console.WriteLine("Tiger feed");
//    }

//    public override void Groom()
//    {
//        Console.WriteLine("Tiger groom if you can");
//    }
//}

#endregion

#region Interface Segregation - Good Example
abstract class Animal
{}

interface IGroom
{
    void Groom();
}
interface IFeed
{
    void Feed();
}

class Dog : Animal, IGroom, IFeed
{
    public void Feed()
    {
        Console.WriteLine("Dog feed");
    }

    public void Groom()
    {
        Console.WriteLine("Dog groom");
    }
}

class Cat : Animal, IGroom, IFeed
{
    public void Feed()
    {
        Console.WriteLine("Cat feed");
    }

    public void Groom()
    {
        Console.WriteLine("Cat groom");
    }
}

class Tiger : Animal, IFeed
{
    public void Feed()
    {
        Console.WriteLine("Tiger feed");
    }
}

#endregion