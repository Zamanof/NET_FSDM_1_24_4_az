Auditory auditory = new();
foreach (Student student in auditory)
{
    Console.WriteLine(student);
}

auditory.Sort();
Console.WriteLine("After sorting: By FirstName");
foreach (Student student in auditory)
{
    Console.WriteLine(student);
}