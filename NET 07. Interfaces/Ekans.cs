// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

class Ekans : Poison, IEvolable, IFlyable
{
    public Ekans(string? name) : base(name)
    {
    }

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public void Evolve()
    {
        throw new NotImplementedException();
    }

    

    public int Fly()
    {
        return 5;
    }

    public override void PoisonAttack()
    {
        throw new NotImplementedException();
    }

    public override void Sound()
    {
        throw new NotImplementedException();
    }

    void IFlyable.Fly()
    {
        Console.WriteLine("Fly");
    }
    // ecplicit implemetation
    //void IFlyable.Fly()
    //{
    //    Console.WriteLine("Fly");
    //}

    //void Fly()
    //{
    //    Console.WriteLine("Doldursan uçar!!!");
    //}
}