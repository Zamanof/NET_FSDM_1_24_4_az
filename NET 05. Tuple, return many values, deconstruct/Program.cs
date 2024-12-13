// tuple
//(int, double) myTuple = (25, 46);
//Console.WriteLine(myTuple.Item1);
//Console.WriteLine(myTuple.Item2);

//(int Sum, double price, string name) myTuple2 = (25, 35.2, "Salam");
//Console.WriteLine(myTuple2.Sum);
//Console.WriteLine(myTuple2.price);
//Console.WriteLine(myTuple2.name);

//(int sum, float aver) =   CalculateSumAndAverage(2, 13);
//Console.WriteLine(sum);
//Console.WriteLine(aver);

//(_, float aver1, _) = CalculateSumAndAverage(2, 13);
//Console.WriteLine(aver1);

// Deconstruct

Car car = new("Prius", "Toyota", 2024);
Console.WriteLine(car);
//var model = car.Model;
//var manufacturer = car.Manufacturer;
//var year = car.Year;

(string model, _, int year) = car;
Console.WriteLine(model);
//Console.WriteLine(man);
Console.WriteLine(year);

(int, float, int) CalculateSumAndAverage(int numb1, int numb2)
{
    int sum = numb1 +numb2;
    var avearge = (numb1 + numb2) / 2.0f;
    return (sum, avearge, 2569);
}

class Car
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }

    public Car(string model, string manufacturer, int year)
    {
        Model = model;
        Manufacturer = manufacturer;
        Year = year;
    }

    // Deconstruct https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/functional/deconstruct
    public void Deconstruct(out string model, out string manufacturer, out int year)
    {
        model = Model;
        manufacturer = Manufacturer;
        year = Year;
    }
    public override string ToString()
    {
        return $"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}";
    }
}
