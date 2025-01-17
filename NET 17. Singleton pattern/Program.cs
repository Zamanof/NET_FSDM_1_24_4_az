// Singleton pattern
// https://refactoring.guru/design-patterns/singleton
President president;
president = President.getInstansce("Salam", "Salamzade", 38);
Console.WriteLine(president);
President president1 = President.getInstansce("Fransuz", "Makaron", 45);
Console.WriteLine(president1);
class President
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    private static President _instance = null;

    private President(string name, string surname, int age)
    {
        Name = name;
        Surname = surname;
        Age = age;
    }
    static public President getInstansce(string name, string surname, int age)
    {
        if (_instance is null)
        {
            _instance = new(name, surname, age);
        }
        return _instance;
    }
    public override string ToString()
    {
        return $"{Name} {Surname} - {Age}";
    }
}
