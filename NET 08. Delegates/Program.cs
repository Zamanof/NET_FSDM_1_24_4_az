// Delegates
// delegate retrun_datatype delegate_name(parameters)
// public delegate int MyIntDelegate(int numb1, int numb2)

#region delegate

//double numb1 = default, numb2 = default;
//Console.WriteLine("Enter first number: ");
//double.TryParse(Console.ReadLine(), out numb1);
//Console.WriteLine("Enter second number: ");
//double.TryParse(Console.ReadLine(), out numb2);

//char operation = default;
//Console.WriteLine("Choice operation: +, -, *, /");
//char.TryParse(Console.ReadLine(), out operation);

//CalculatorDelegate calculator = null;

//switch ((operators)operation)
//{
//    case operators.ADD:
//        calculator = Add;
//        break;
//    case operators.SUBRTACT:
//        calculator = Subtract;
//        break;
//    case operators.MULTIPLE:
//        calculator = Multiple;
//        break;
//    case operators.DIVIDE:
//        calculator = Divide;
//        break;
//    default:
//        Console.WriteLine("Incorrect operation!!!");
//        break;
//}
////if (calculator is not null)
////{
////    Console.WriteLine(calculator(numb1, numb2));
////}

//if (calculator is not null)
//{
//    Console.WriteLine(calculator.Invoke(numb1, numb2));

//}

//double Add(double left, double right)
//{
//    return left + right;
//}
//double Subtract(double left, double right)
//{
//    return left - right;
//}
//double Multiple(double left, double right)
//{
//    return left * right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//public delegate double CalculatorDelegate(double left, double right);
//enum operators { ADD = '+', SUBRTACT = '-', MULTIPLE = '*', DIVIDE = '/' }
#endregion

#region Multicast delegates
//CalculatorDelegate calculators = Add;
//calculators += Subtract;
//calculators += Multiple;
//calculators += Divide;

//double number1 = 56, number2 = 32;

//Console.WriteLine(calculators(number1, number2));

//foreach( CalculatorDelegate calculator in calculators.GetInvocationList())
//{
//    Console.WriteLine(calculator(number1, number2));
//}

//var delegateList = calculators.GetInvocationList();
//Console.WriteLine(delegateList[0].Method);
//Console.WriteLine(delegateList[1].Method);
//Console.WriteLine(delegateList[3].DynamicInvoke(25, 22));


// Generic delegate
//GenericCalcDelegate<double> genericCalcDouble = Add;
//GenericCalcDelegate<int> genericCalcInt = SomeFunction;
//Console.WriteLine(genericCalcDouble.Invoke(20, 15));
//Console.WriteLine(genericCalcInt.Invoke(20, 15)); 



//double Add(double left, double right)
//{
//    return left + right;
//}
//double Subtract(double left, double right)
//{
//    return left - right;
//}
//double Multiple(double left, double right)
//{
//    return left * right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

//int SomeFunction (int numb1, int numb2)
//{
//    return numb1 % numb2;
//}

//public delegate double CalculatorDelegate(double left, double right);

//// Generic delagates
//public delegate T GenericCalcDelegate<T>(T left, T right);
#endregion

#region Standard generic delgates Action<T>, Func<t>, Predicate<T>, Comparison<T>
// Action<T>, Func<T>, Predicate<T>, Comparison<T>
List<int> ints = [25, 32, 6, -54, 1, -89, 2, -554, 1, 7, 112];
#region delegate in functions
//var results = filter(ints, delegate (int n) { return n % 2 == 0; });

//foreach (var i in results)
//{
//	Console.Write($"{i} ");
//}
//Console.WriteLine();
//List<int> filter(List<int> ints, FilterDelegate filterDelegate)
//{
//	List<int> result = new List<int>();
//	foreach (var item in ints)
//	{
//		if (filterDelegate(item)) result.Add(item);
//	}
//	return result;
//}
#endregion

#region Action
//int[] arr = new int[13];
//Random random = new Random();
//for (int i = 0; i < arr.Length; i++)
//{
//    arr[i] = random.Next(-99, 99);
//}

//foreach (int i in arr)
//{
//    Console.Write($"{i} ");
//}
//Console.WriteLine();
////  Action<int> action <=> public delegate void del_name(int n)

//FilteringShow(arr, ShowSquare);

//Action<int, double, string> action = Foo;

//action(25, 23.5, "Salam");
//void Foo(int numb, double numb1, string str)
//{
//    Console.WriteLine($"{str} - {numb * numb1}");
//}

//void FilteringShow(int[] arr, Action<int> action)
//{
//    foreach (var item in arr)
//    {
//        action(item);
//    }
//    Console.WriteLine();
//}


//void ShowNegate(int numb)
//{
//    if(numb < 0) Console.Write($"{numb} ");
//}

//void ShowSquare(int numb) 
//{
//    Console.Write($"{numb * numb}   ");
//}
#endregion

#region Func
//Console.WriteLine(Calculator(25.6, 32.5, Divide));


//double Calculator(double numb1, double numb2, Func<double, double, double> func)
//{
//    return func(numb1, numb2);
//}
//double Add(double left, double right)
//{
//    return left + right;
//}
//double Subtract(double left, double right)
//{
//    return left - right;
//}
//double Multiple(double left, double right)
//{
//    return left * right;
//}

//double Divide(double left, double right)
//{
//    if (right != 0) return left / right;
//    throw new DivideByZeroException();
//}

#endregion

#region Comparison
//List<Human> humans = [
//    new Human(){Name = "Nadir", Age = 44},
//    new Human(){Name = "Salam", Age = 25},
//    new Human(){Name = "Ali", Age = 15},
//    new Human(){Name = "Baba", Age = 135},
//    new Human(){Name = "Qadir", Age = 25}    
//    ];
//foreach (var human in humans)
//{
//    Console.WriteLine(human);
//}
//humans.Sort(NameComparison);
//Console.WriteLine();
//foreach (var human in humans)
//{
//    Console.WriteLine(human);
//}

//int AgeComparison(Human left, Human right)
//{
//    //return left.Age.CompareTo(right.Age);
//    if (left.Age > right.Age) return 1;
//    else if(left.Age < right.Age) return -1;
//    return 0;
//}

//int NameComparison(Human left, Human right)
//{
//    return left.Name.CompareTo(right.Name);

//}

#endregion


#region Predicate
var results = filter(ints, isPositive);

foreach (var i in results)
{
	Console.Write($"{i} ");
}
Console.WriteLine();
List<int> filter(List<int> ints, Predicate<int> predicate)
{
	List<int> result = new List<int>();
	foreach (var item in ints)
	{
		if (predicate(item)) result.Add(item);
	}
	return result;
}

#endregion
bool isNegative(int number) 
{
	return number < 0;
}

bool isPositive(int number)
{
    return number > 0;
}

public delegate bool FilterDelegate(int value);

class Human
{
    public string Name { get; set; }
    public int Age { get; set; }
    public override string ToString()
    {
        return $"{Name} - {Age}";
    }
}

#endregion