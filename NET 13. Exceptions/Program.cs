using NET_12._Exceptions;

// Exceptions

// Exception
//  - SystemException
//  - ApllicationException

int numb1 = 3;
int numb2 = 2;
int result = default;


try
{
    result = numb1 / numb2;
    Console.WriteLine(result);
    //Foo(2, 0);
    Salam();
}
catch(DivideByZeroException ex) 
{
    Console.WriteLine("Catch in Main - DivideByZeroException");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
}
catch (MyException ex)
{
    Console.WriteLine("Catch in Main - My exception");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
}
catch (Exception ex)
{
    Console.WriteLine("Catch in Main - Any exception");
    Console.WriteLine();
    Console.WriteLine($"Message - {ex.Message}");
    Console.WriteLine();
    Console.WriteLine($"Stack trace - {ex.StackTrace}");
    Console.WriteLine();
    Console.WriteLine($"Target site - {ex.TargetSite}");
    //throw new Exception("Bu gemi batacaq!!!");
   
}
//finally {
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine("Finally block");
//}

int Foo(int a, int b)
{
    int result = default;
    int[] arr = new int[5];
    try
    {
        result = a / b;
        Console.WriteLine(arr[8]);
    }
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Catch in Foo method - DivideByZeroException");
        Console.WriteLine();
        Console.WriteLine($"Message - {ex.Message}");
        //throw new Exception("Salam Aleykum");
        throw new MyException("This is Spartaaaaa!");
    }
    return result;
}

void Bar()
{
    Foo(5, 0);
}

void Salam()
{
    Bar();
}
