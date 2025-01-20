// Factory method
using NET_18._Factory_Method.Abstract;

internal class Ship : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by sea in big containers!"); ;
    }
}