// Flyweight pattern

FlyWeightFactory factory = new();

List<UnitFlyWeight> units = new List<UnitFlyWeight>();
for (int i = 0; i < 1000000; i++)
{
    //Archer unitArcher = new Archer();
    //Warrior unitWarrior = new Warrior();

    UnitFlyWeight unitArcher = factory.GetUnit("Archer");
    UnitFlyWeight unitWarrior = factory.GetUnit("Warrior");

    //unitArcher.Display();
    Console.WriteLine(unitArcher.GetHashCode());
    Console.WriteLine(unitWarrior.GetHashCode());

    units.Add(unitArcher);
    units.Add(unitWarrior);
}
Console.ReadKey();

abstract class UnitFlyWeight
{
    protected string Name;
    protected int AttackPoint;
    protected int Health;

    public abstract void Display();
}

class Archer : UnitFlyWeight
{
    public Archer()
    {
        Name = "Archer";
        AttackPoint = 90;
        Health = 50;
    }

    public override void Display()
    {
        Console.WriteLine("Archer created"); ;
    }
}

class Warrior : UnitFlyWeight
{
    public Warrior()
    {
        Name = "Warrior";
        AttackPoint = 50;
        Health = 150;
    }

    public override void Display()
    {
        Console.WriteLine("Warrior created"); ;
    }
}

class FlyWeightFactory
{
    private Dictionary<string, UnitFlyWeight> _units = new();

    public UnitFlyWeight GetUnit(string key)
    {
        UnitFlyWeight unit = default;
        if (_units.ContainsKey(key))
        {
            unit = _units[key];
        }
        else
        {
            switch (key)
            {
                case "Archer":
                    unit = new Archer();
                    break;
                case "Warrior":
                    unit = new Warrior();
                    break;
            }
            _units.Add(key, unit);
        }
        return unit;
    }
}
