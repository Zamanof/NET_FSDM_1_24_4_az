List<Group> groups = [
    new Group(){Id = 1, Name="FSDM_1_24_4_az", Faculty="Programming"},
    new Group(){Id = 2, Name="FSDM_2_24_4_az", Faculty="Programming"},
    new Group(){Id = 3, Name="DSGN_1_24_4_az", Faculty="Design"},
    new Group(){Id = 4, Name="DSGN_2_24_4_az", Faculty="Design"},
    new Group(){Id = 5, Name="CYBR_1_24_4_az", Faculty="Cybersecurity"},
    new Group(){Id = 6, Name="CYBR_2_24_4_az", Faculty="Cybersecurity"},
    new Group(){Id = 7, Name="FSDM_3_24_4_az", Faculty="Programming"},
    new Group(){Id = 8, Name="DSGN_3_24_4_az", Faculty="Design"},
    new Group(){Id = 9, Name="CYBR_3_24_4_az", Faculty="Cybersecurity"},
    new Group(){Id = 10, Name="FSDM_4_24_4_az", Faculty="Programming"}
    ];
List<Student> students = [
    new Student {FirstName = "Salam", LastName="Salamzade", Age = 25, GroupId=2},
    new Student {FirstName = "Ali", LastName="Aliyev", Age = 22, GroupId=1},
    new Student {FirstName = "Leyla", LastName="Hasanova", Age = 21, GroupId=2},
    new Student {FirstName = "Nigar", LastName="Qasimova", Age = 23, GroupId=3},
    new Student {FirstName = "Elvin", LastName="Mammadov", Age = 24, GroupId=4},
    new Student {FirstName = "Sara", LastName="Ahmadova", Age = 20, GroupId=5},
    new Student {FirstName = "Kamran", LastName="Rasulov", Age = 25, GroupId=6},
    new Student {FirstName = "Ramin", LastName="Mustafayev", Age = 22, GroupId=7},
    new Student {FirstName = "Zahra", LastName="Karimova", Age = 21, GroupId=8},
    new Student {FirstName = "Turan", LastName="Aliyev", Age = 24, GroupId=9},
    new Student {FirstName = "Ayan", LastName="Nabiyev", Age = 23, GroupId=10},
    new Student {FirstName = "Javid", LastName="Suleymanov", Age = 22, GroupId=1},
    new Student {FirstName = "Arzu", LastName="Farzaliyeva", Age = 21, GroupId=2},
    new Student {FirstName = "Farid", LastName="Guliyev", Age = 25, GroupId=3},
    new Student {FirstName = "Narmin", LastName="Hajiyeva", Age = 20, GroupId=4},
    new Student {FirstName = "Ilkin", LastName="Rahimov", Age = 23, GroupId=5},
    new Student {FirstName = "Sabina", LastName="Mahmudova", Age = 22, GroupId=6},
    new Student {FirstName = "Rustam", LastName="Mirzayev", Age = 24, GroupId=7},
    new Student {FirstName = "Gunel", LastName="Aliyeva", Age = 21, GroupId=8},
    new Student {FirstName = "Vusal", LastName="Ibrahimov", Age = 25, GroupId=9},
    new Student {FirstName = "Elmir", LastName="Huseynov", Age = 23, GroupId=10},
    new Student {FirstName = "Sevda", LastName="Ismayilova", Age = 22, GroupId=1},
    new Student {FirstName = "Murad", LastName="Gasimov", Age = 24, GroupId=2},
    new Student {FirstName = "Parviz", LastName="Najafov", Age = 25, GroupId=3},
    new Student {FirstName = "Lala", LastName="Taghiyeva", Age = 21, GroupId=4},
    new Student {FirstName = "Aysel", LastName="Babayeva", Age = 20, GroupId=5},
    new Student {FirstName = "Fikret", LastName="Nabiyev", Age = 23, GroupId=6},
    new Student {FirstName = "Samil", LastName="Karimov", Age = 22, GroupId=7},
    new Student {FirstName = "Konul", LastName="Rahmanova", Age = 24, GroupId=8},
    new Student {FirstName = "Jalal", LastName="Sharifov", Age = 21, GroupId=9},
    new Student {FirstName = "Azad", LastName="Mammadli", Age = 25, GroupId=10},
    new Student {FirstName = "Elshan", LastName="Jafarov", Age = 22, GroupId=1},
    new Student {FirstName = "Aida", LastName="Rustamova", Age = 21, GroupId=2},
    new Student {FirstName = "Ilgar", LastName="Tagiyev", Age = 23, GroupId=3},
    new Student {FirstName = "Teymur", LastName="Hasanov", Age = 24, GroupId=4},
    new Student {FirstName = "Feride", LastName="Aliyeva", Age = 20, GroupId=5},
    new Student {FirstName = "Nazim", LastName="Mikayilov", Age = 25, GroupId=6},
    new Student {FirstName = "Kamila", LastName="Qurbanova", Age = 22, GroupId=7},
    new Student {FirstName = "Samir", LastName="Aslanov", Age = 21, GroupId=8},
    new Student {FirstName = "Rovshan", LastName="Sharifov", Age = 23, GroupId=9},
    new Student {FirstName = "Taleh", LastName="Rasulov", Age = 24, GroupId=10}
    ];

var result = from g in groups
             join s in students on g.Id equals s.GroupId
             orderby s.FirstName
             select new {
                 FirstName=s.FirstName, 
                 LastName = s.LastName, 
                 Age = s.Age,
                 GroupName = g.Name
             };

foreach(var stud in result)
{
    Console.WriteLine($"{stud.FirstName} {stud.LastName} {stud.Age} - {stud.GroupName}");
}

var groupByGroup = from r in result
                   group r by r.GroupName;

foreach (var gr in groupByGroup)
{
    Console.WriteLine(gr.Key);
    foreach(var stud in gr)
    {
        Console.WriteLine($"\t{stud.FirstName} {stud.LastName} {stud.Age} - {stud.GroupName}");
    }
}
class Student
{
    public uint Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public byte Age { get; set; }
    public uint GroupId { get; set; }
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