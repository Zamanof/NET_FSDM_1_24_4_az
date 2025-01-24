// Chain of Responsibility


class Linker : CompilerCoR
{
    public override void Handle()
    {
        Console.WriteLine("Linker");
        Next?.Handle();
    }
}
