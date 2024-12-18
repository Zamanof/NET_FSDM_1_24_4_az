// Abstract class

// is əlaqəsidir - Mənsubiyyət bildirir (Sphynx is Cat is Animal, Student is Human)

#region Abstract class introduction
//Some some = new();

//Other other = new();

//abstract class Some
//{

//    public int SomeIntField;
//    public string SomeStringField { get; set; }

//    public virtual void SomeMethod()
//    {
//        Console.WriteLine("Some method");
//    }

//    public abstract void SomeAbstractMethod();

//}

//abstract class Other: Some
//{
//    public int OtherIntField;
//}
#endregion
Pikachu pikachu = new("My Pika");
Charmander charmander = new("My Charma");
Pokemon[] pokemons = [pikachu, charmander, new Pikachu("other pika")];
Fire[] firePokemons = [
    charmander, 
    new Charmander("Unicode Char"), 
    new Charmander("Ascii Char")];

//foreach (var item in pokemons)
//{
//    item.Sound();
//}

Fight(pikachu, charmander);
FirePokemonsGym(charmander);
void Fight(Pokemon left, Pokemon right)
{
    left.Attack();
    right.Attack();
}

void FirePokemonsGym(Fire firePokemon)
{
    firePokemon.LevelUp();
}

class Pokedex
{
    private List<Pokemon> Pokemons { get; set; }= new List<Pokemon>();

    public void GetAllPokemons()
    {
        foreach(Pokemon p in Pokemons)
        {
            Console.WriteLine(p.Name);
        }
    }

    public void Add(Pokemon pokemon)
    {
        Pokemons.Add(pokemon);
    }
}
