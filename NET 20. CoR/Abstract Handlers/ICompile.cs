// Chain of Responsibility


interface ICompile
{
    CompilerCoR SetNext(CompilerCoR next);
    void Handle();
}
