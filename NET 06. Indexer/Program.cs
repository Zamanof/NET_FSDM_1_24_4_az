// Indexer - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/indexers/
// public return_type this[params]{get; set;}

//Garage garage = new(3);
//garage[0] = new Car { Model = "Toyota", Price = 23215 };
//garage[1] = new Car { Model = "Audi", Price = 36154 };
//Console.WriteLine(garage[5]);
//for (int i = 0; i < garage.Count; i++)
//{
//    Console.WriteLine(garage[i]);
//}
//Console.WriteLine(garage["Toyota"]);
//garage["Toyota"].Price = 1236423;
//Console.WriteLine(garage["Toyota"]);
//Console.WriteLine(garage["Audi"]);
Random random = new Random();
MultiArray multiArray = new(3, 3);
for (int i = 0; i < multiArray.Rows; i++)
{
    for (int j = 0; j < multiArray.Columns; j++)
    {
        multiArray[i, j] = random.Next(10, 99);
    }
}

for (int i = 0; i < multiArray.Rows; i++)
{
    for (int j = 0; j < multiArray.Columns; j++)
    {
        Console.Write($"{multiArray[i, j]} ");
    }
    Console.WriteLine();
}

class Car
{
    public string Model { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"{Model} - {Price}$";
    }
}

class Garage
{
    Car[] cars;

    public Garage(int count)
    {
        cars = new Car[count];
    }
    public int Count
    {
        get { return cars.Length; }
    }

    public Car this[int index]
    {
        get
        {
            if (index >= 0 && index < cars.Length)
            {
                return cars[index];
            }
            throw new IndexOutOfRangeException();
        }
        set
        {
            cars[index] = value;
        }
    }

    public Car this[string model]
    {
        get
        {
            if (Enum.IsDefined(typeof(Models), model))
            {
                return cars[(int)Enum.Parse(typeof(Models), model)];
            }
            return new Car();
        }
        set
        {
            cars[(int)Enum.Parse(typeof(Models), model)] = value;
        }
    }
}

class MultiArray
{
    int[,] array;
    public int Rows { get; set; }
    public int Columns { get; set; }

    public MultiArray(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        array = new int[rows, columns];
    }

    public int this[int row, int column]
    {
        get => array[row, column];
        set => array[row, column] = value;
    }
}

enum Models { Toyota, Audi, NAZ, Lamborghini, Nissan, VAZ, Hyundai }