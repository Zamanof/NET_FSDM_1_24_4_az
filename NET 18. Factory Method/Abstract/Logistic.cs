namespace NET_18._Factory_Method.Abstract;

internal abstract class Logistic
{
    public abstract ITransport CreateTransort();
    public void Delivery()
    {
        Console.WriteLine("Logistic Delivery");
    }

}
