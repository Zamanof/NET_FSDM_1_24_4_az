class Student
{
    public uint Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set;}
    public byte Age { get; set; }
    public uint GroupId {  get; set; }
    static uint count = 1;

    public Student()
    {
        Id = count++;
    }
    public override string ToString()
    {
        return $"""
            Id:{Id}
            FirstName:      {FirstName}
            LastName:       {LastName}
            Age:            {Age}
            GroupId         {GroupId}
            """;
    }
}
class Group 
{
    public uint Id { get; set; }
    public string? Name { get; set; }
    public string? Faculty { get; set; }

    public override string ToString()
    {
        return $"""
            Id: {Id}
            Name:       {Name}
            Faculty:    {Faculty}
            """;
    }
}