// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

abstract class Poison : Pokemon
{
    protected Poison(string? name) : base(name)
    {
    }

    public abstract void PoisonAttack();
}

