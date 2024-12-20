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
GenericCalcDelegate<double> genericCalcDouble = Add;
GenericCalcDelegate<int> genericCalcInt = SomeFunction;
Console.WriteLine(genericCalcDouble.Invoke(20, 15));
Console.WriteLine(genericCalcInt.Invoke(20, 15)); 



double Add(double left, double right)
{
    return left + right;
}
double Subtract(double left, double right)
{
    return left - right;
}
double Multiple(double left, double right)
{
    return left * right;
}

double Divide(double left, double right)
{
    if (right != 0) return left / right;
    throw new DivideByZeroException();
}

int SomeFunction (int numb1, int numb2)
{
    return numb1 % numb2;
}

public delegate double CalculatorDelegate(double left, double right);

// Generic delagates
public delegate T GenericCalcDelegate<T>(T left, T right);
#endregion