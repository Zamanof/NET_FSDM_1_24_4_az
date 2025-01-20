// Factory method
using NET_18._Factory_Method.Abstract;
using NET_18._Factory_Method.Concrete;

Logistic logistic = new RoadLogistic();
DeliverProducts(logistic, "Coca Cola");
DeliverProducts(new AirLogistic(), "Coca Cola");
DeliverProducts(new SeaLogistic(), "Coca Cola");



void DeliverProducts(Logistic logistic, string productName)
{
    ITransport transport = logistic.CreateTransort();
    transport.Deliver(productName);
}