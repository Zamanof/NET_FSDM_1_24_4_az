// Factory method
using NET_18._Factory_Method.Abstract;

internal class AirLogistic : Logistic
{
    public override ITransport CreateTransort()
    {
        return new Airplane();
    }
}