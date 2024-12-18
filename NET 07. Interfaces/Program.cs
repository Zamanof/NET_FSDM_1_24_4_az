// interfaces -  contract, do something
// class-dan törəyirik(inheritance)
// intreface-i realizasiya edirik(implementation)

#region Interface
//IWalk thinkObject = new Student();

//Foo(new Student());
//Foo(new AI());
//Bar(new Student());

//void Foo(IThink think)
//{

//}

//void Bar(IWalk think)
//{

//}

//abstract class Human
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//}
//interface IThink
//{
//    public void Think();
//}
//interface IWalk
//{
//    public void Walk();
//}

//interface IHomoSapiens: IThink, IWalk
//{}
//class Student: Human, IHomoSapiens
//{
//    public float[] marks { get; set; }

//    public void Think()
//    {
//        Console.WriteLine("Think like student");
//    }

//    public void Walk()
//    {
//        Console.WriteLine("Walk like human");
//    }
//}
//class AI : IThink
//{
//    public void Think()
//    {
//        throw new NotImplementedException();
//    }
//}
#endregion

Ekans ekans = new("Ekans");
//Console.WriteLine(ekans.Fly());
//ButaAirways(ekans);
ButaAirways(new Charmander("ch"));
void ButaAirways(IFlyable flyable)
{
    flyable.Fly();
    Console.WriteLine( (flyable as Ekans)?.Fly());
}

//EvolveAll([new Pikachu("Pika"), new Charmander("Charm")]);

//void EvolveAll(IEvolable[] evolables)
//{
//	foreach (var pokemon in evolables)
//	{
//		pokemon.Evolve();
//	}
//}