// Observer - Mushahidechi

// Also known as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscribers



class ProductManager
{
    private List<Observer> _observers = new List<Observer> ();
    public void UpdatePrice()
    {
        Notify("Product price changed!!!");
    }

    public void Attach(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }
    private void Notify(string message)
    {
        foreach (Observer observer in _observers)
        {
            observer.Update(message);
        }
    }
}
