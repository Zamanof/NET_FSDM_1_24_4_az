// Chain of Responsibility


class NewChain : CompilerCoR
{
    public override void Handle()
    {
        Console.WriteLine("Some magic code");
        Next?.Handle();
    }
}
