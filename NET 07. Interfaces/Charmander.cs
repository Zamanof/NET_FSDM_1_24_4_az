// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

class Charmander : Fire, IFlyable, IEvolable
{
    public Charmander(string? name):base(name)
    { }

    public override void Attack()
    {
        Console.WriteLine("Charmander attacked");
    }

    public void Evolve()
    {
        Console.WriteLine("Evolve to Charmeleon"); ;
    }

    public override void FireAttack()
    {
        Console.WriteLine("Charmander fire attacked");
        
    }

    public void Fly()
    {
        Console.WriteLine("Can flye");
    }

    public override void Sound()
    {
        Console.WriteLine("chaaaarmandeerr");
    }
}
