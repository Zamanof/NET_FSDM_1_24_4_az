// See https://aka.ms/new-console-template for more information
public class StudentCard
{
    public int Id { get; set; }
    public string? Series { get; set; }

    public override string ToString()
    {
        return $"Student card: {Series} {Id}";
    }
}