// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

class Charizard : Fire, IFlyable
{
    public Charizard(string? name) : base(name)
    {
    }

    public override void Attack()
    {
        throw new NotImplementedException();
    }

    public override void FireAttack()
    {
        throw new NotImplementedException();
    }

    public void Fly()
    {
        throw new NotImplementedException();
    }

    public override void Sound()
    {
        throw new NotImplementedException();
    }
}