// See https://aka.ms/new-console-template for more information
class Student: IComparable
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public DateTime BirthDate { get; set; }
    public StudentCard? StudentCard { get; set; }

    public int CompareTo(object? obj)
    {
       if (obj is Student)
        {
            return FirstName!.CompareTo((obj as Student)!.FirstName);
        }
       throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"""
            Name:           {FirstName}
            Surname:        {LastName}
            BirthDate:      {BirthDate.ToShortDateString()}
            StudentCard:    {StudentCard}

            """;
    }

}
