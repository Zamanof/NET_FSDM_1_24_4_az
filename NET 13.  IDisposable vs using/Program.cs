//MyClass myClass = new MyClass();
//try
//{
//    myClass.Foo();
//}
//finally
//{
//    myClass.Dispose();
//}

// using - syntax sugar
//using (MyClass my = new())
//{
//    my.Foo();
//}

using (MyClass my = new())
my.Foo();


class MyClass : IDisposable
{
    private bool _isDisposed = false;
    public MyClass()
    {
        Console.WriteLine("Constructor...");
    }

    private void Cleaning(bool disposing)
    {
        if (!_isDisposed)
        {
            if (disposing)
            {
                Console.WriteLine("Managed resources are cleaned");
            }
            Console.WriteLine("Unmanaged resources are cleaned");
            _isDisposed = true;
        }
    }
    public void Dispose()
    {
        Cleaning(true);
        GC.SuppressFinalize(this);
    }

    public void Foo()
    {
        Console.WriteLine("Some magic operations...");
        throw new NotImplementedException();
    }

    ~MyClass()
    {
        Cleaning(false);
    }
}

