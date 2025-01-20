using NET_18._Factory_Method.Abstract;

namespace NET_18._Factory_Method.Concrete;

internal class RoadLogistic : Logistic
{
    public override ITransport CreateTransort()
    {
        return new Truck();
    }
}
