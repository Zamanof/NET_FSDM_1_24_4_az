// Observer - Mushahidechi

// Also known as: Event-Subscriber, Listener

// Subject - Publisher
// Observer - Subscribers



class EmolyeeObserver : Observer
{
    public override void Update(string message)
    {
        Console.WriteLine($"Message to employee: {message}"); ;
    }
}