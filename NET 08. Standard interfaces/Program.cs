Auditory auditory = new();
//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

//auditory.Sort();
//auditory.Sort(new LastNameComparer());
//auditory.Sort(new DateComparer());

//Console.WriteLine();
//foreach (Student student in auditory)
//{
//    Console.WriteLine(student);
//}

Student student = new Student()
{
    FirstName = "Ridan",
    LastName = "Vonamaz",
    Email = "vonamaz@tipets.gro",
    BirthDate = DateTime.Now,
    StudentCard = new StudentCard() { Series="NZ", Id=655665}
};

Student? student1 = student.Clone() as Student;
Console.WriteLine(student);
Console.WriteLine();
Console.WriteLine(student1);

student.FirstName = "ALi";
Console.WriteLine();
Console.WriteLine(student);
Console.WriteLine();
Console.WriteLine(student1);
