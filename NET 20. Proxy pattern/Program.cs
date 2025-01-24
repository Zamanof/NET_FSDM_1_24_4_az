// Proxy pattern - komekchi, vekil, katib


/*
    1. Protection proxy
    2. Virtual proxy (Lazy initialization)
    3. Remote proxy (CDN)
    4. Logging Proxy
    5. Cashing proxy
 */

#region Protection Proxy Example

OperationProxy operationProxy = new(new RealOperationSubject(), 0);
operationProxy.Request();

interface IOperation
{
    void Request();
}

// Real subject (Real Service)
class RealOperationSubject : IOperation
{
    public void Request()
    {
        Console.WriteLine("Do something"); ;
    }
}

// Proxy  (Proxy Service)
class OperationProxy : IOperation
{
    private IOperation _operation { get; set; }
    private int _role;
    public OperationProxy(IOperation operation, int role)
    {
        _operation = operation;
        _role = role; 
    }

    public void Request()
    {

        if (_role == 1)
        {
            _operation.Request();
        }
        else
        {
            Console.WriteLine("401 unauthorized");
        }
    }
}


#endregion

