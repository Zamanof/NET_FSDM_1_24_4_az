// Factory method
using NET_18._Factory_Method.Abstract;

internal class SeaLogistic : Logistic
{
    public override ITransport CreateTransort() => new Ship();
}