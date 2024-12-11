// class

//Console.WriteLine(human3.field2);
// class
//Console.WriteLine(human3.field2);
// internal - yalnız elan edildiyi assembly daxilində əlçatandır
// public - istənilən assembly daxilində əlçatan olacaq
class Human
{
    // private
    // public
    // protected
    // internal - yalnız bizim assembly daxilində əlçatandır
    // protected internal -  yalnız bizim assembly daxilində törəyən class-larda əlçatandır
    public string name;
    public string surname;
    public int age;

    public static int count;
    public const int field1 = 25;
    public readonly int field2 = 48;

    public Human()
        : this(surname: "Doe", age: 18, name: "John")
    // constructor-ların deleqasiya olunmasi
    {
        //Console.WriteLine("Parameterless constructor.");
    }

    public Human(string name, string surname, int age)
    {
        //Console.WriteLine(" constructor Human(string name, string surname, int age)");
        this.name = name;
        this.surname = surname;
        this.age = age;
    }
    static Human()
    {
        count = 5;
    }


    public void Foo()
    {
        Console.WriteLine("Foo");
        Dog.Some(this);
    }
    public override string ToString()
    {
        return $@"Name: {name}
Surname: {surname}
Age: {age}";
    }

    // Finalizer - obyekt "öləndə" çağırılan metod (!!!DESTRUCTOR DEYİL!!!)
    ~Human()
    {

    }
}

