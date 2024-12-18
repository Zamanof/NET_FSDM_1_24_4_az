// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

class Pikachu : Electric
{
    public Pikachu(string? name)
        :base(name)
    {}

    public override void Attack()
    {
        Console.WriteLine("Pikachu attacked");
    }

    public override void ElectricAttack()
    {
        Console.WriteLine("Pikachu electric attacked"); ;
    }

    public  void SpecialElectricAttack()
    {
        Console.WriteLine("Pikachu special electric attacked"); ;
    }

    public override void Sound()
    {
        Console.WriteLine("Pika Pika"); ;
    }
}
