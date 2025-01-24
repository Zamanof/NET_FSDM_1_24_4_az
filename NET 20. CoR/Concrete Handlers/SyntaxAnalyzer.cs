// Chain of Responsibility


class SyntaxAnalyzer : CompilerCoR
{
    public override void Handle()
    {
        Console.WriteLine("Syntax Analyzer");        
        Next?.Handle();
    }
}
