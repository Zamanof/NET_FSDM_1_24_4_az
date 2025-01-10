MyClass myClass = new MyClass();
myClass.Foo();
myClass.Dispose();


class MyClass: IDisposable
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
