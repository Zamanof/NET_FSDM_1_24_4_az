// Chain of Responsibility


class LexicalAnalyzer : CompilerCoR
{
    public override void Handle()
    {
        Console.WriteLine("Lexical Analyzer");
        Next?.Handle();
    }
}
