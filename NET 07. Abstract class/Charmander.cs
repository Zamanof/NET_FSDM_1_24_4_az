// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

class Charmander : Fire
{
    public Charmander(string? name):base(name)
    { }

    public override void Attack()
    {
        Console.WriteLine("Charmander attacked");
    }

    public override void FireAttack()
    {
        Console.WriteLine("Charmander fire attacked");
        
    }

    public override void Sound()
    {
        Console.WriteLine("chaaaarmandeerr");
    }
}