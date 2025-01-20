// Factory method
using NET_18._Factory_Method.Abstract;

internal class Airplane : ITransport
{
    public void Deliver(string productName)
    {
        Console.WriteLine($"Deliver {productName} by air in container!");
    }
}