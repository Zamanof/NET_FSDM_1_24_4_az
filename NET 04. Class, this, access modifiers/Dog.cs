// class

//Human human = new(); // Human human = new Human();
//Human human1 = new("Ali", "Aliyev", 99);
//Human human2 = new(surname: "Zamanov", name: "Nadir", age: 44);
//Human human3 = new()
//{
//    name = "Salam",
//    surname = "Salamzade",
//    age = 44
//};
////Console.WriteLine(human3.field2);
//Console.WriteLine(human3);

// primary constructor - new in C# 12
class Dog(string name, int age, float price) {
    public int some;
    

    public static void Some(Human human)
    {
        Console.WriteLine("Some method");
        Console.WriteLine(human);
    }
    public override string ToString()
    {
        return $"Name: {name}, Age: {age}, Price:{price} AZN";
    }
}