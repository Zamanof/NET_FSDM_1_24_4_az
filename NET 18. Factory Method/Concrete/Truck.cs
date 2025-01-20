using NET_18._Factory_Method.Abstract;

namespace NET_18._Factory_Method.Concrete;

internal class Truck : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by land in box!");
    }
}