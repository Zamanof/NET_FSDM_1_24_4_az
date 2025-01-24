// Chain of Responsibility


abstract class CompilerCoR : ICompile
{
    protected CompilerCoR Next { get; set; }

    public virtual CompilerCoR SetNext(CompilerCoR next)
    {
        Next = next;
        return this;
    }

    public abstract void Handle();

}
