// LINQ methods
// https://learn.microsoft.com/en-us/dotnet/csharp/linq/get-started/introduction-to-linq-queries


using System.Threading.Channels;

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
    new Student {FirstName = "Ramin", LastName="Mustafayev", Age = 35, GroupId=7},
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
    new Student {FirstName = "aida", LastName="Tagiyev", Age = 23, GroupId=3},
    new Student {FirstName = "Teymur", LastName="Hasanov", Age = 24, GroupId=4},
    new Student {FirstName = "Feride", LastName="Aliyeva", Age = 20, GroupId=5},
    new Student {FirstName = "Nazim", LastName="Mikayilov", Age = 25, GroupId=6},
    new Student {FirstName = "Kamila", LastName="Qurbanova", Age = 22, GroupId=7},
    new Student {FirstName = "Samir", LastName="Aslanov", Age = 21, GroupId=8},
    new Student {FirstName = "Rovshan", LastName="Sharifov", Age = 23, GroupId=9},
    new Student {FirstName = "Taleh", LastName="Rasulov", Age = 24, GroupId=10},
    new Student {FirstName = "Nazim", LastName="Faytonchu", Age = 56, GroupId=6}
    ];

#region First, FirstOrDefault
//var stud = students.First(s => s.GroupId == 3);
//Console.WriteLine(stud);

//var stud1 = students.FirstOrDefault(s => s.GroupId == 11);
//if (stud1 is not null) Console.WriteLine(stud1);
//else Console.WriteLine("Student not found");
#endregion

#region Single, SingleOrDefault
//var stud = students.Single(s => s.FirstName == "Nazim");
//Console.WriteLine(stud);

//var stud1 = students.SingleOrDefault(s => s.FirstName == "Nazim");
//if (stud1 is not null) Console.WriteLine(stud1);
//else Console.WriteLine("Student not found");
#endregion

#region Contains
//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 44,
//    GroupId = 4
//};
//students.Add(student);
//var value = students.Contains(student);
//Console.WriteLine(value);
#endregion

#region Where
//var stud = students.Where(s => s.Age > 22);
//foreach (var item in stud)
//{
//    Console.WriteLine(item);
//}

//var student = new Student
//{
//    FirstName = "Nadir",
//    LastName = "Zamanov",
//    Age = 44,
//    GroupId = 4
//};
//students.Add(student);
//Console.WriteLine("After add student!");
//foreach (var item in stud)
//{
//    Console.WriteLine(item);
//}


//var studentsQuery = from i in students
//                    where i.Age > 22
//                    select i;
//foreach (var item in studentsQuery)
//{
//    Console.WriteLine(item);
//}
#endregion

#region Min, Max, Average, Sum
//var minResult = students.Min(s => s.Age);
//Console.WriteLine(minResult);
//var maxResult = students.Max(s => s.Age);
//Console.WriteLine(maxResult);
//var minName = students.Min(s=> s.FirstName);
//Console.WriteLine(minName);

//var aver = students.Average(s=> s.Age);
//Console.WriteLine(aver);

//Console.WriteLine(students.Sum(s=>s.Age));

#endregion

#region OrderBy, OrderByDescending, ThenBy, ThenByDescending
//var stud = students.OrderBy(s => s.Age).ToList();
//stud.ForEach(Console.WriteLine);

//var studDesc = students.OrderByDescending(s => s.Age).ToList();
//studDesc.ForEach(Console.WriteLine);

//var studs = students.OrderBy(s=> s.Age).ThenBy(s=>s.FirstName).ToList();

//studs.ForEach(Console.WriteLine);

#endregion

#region Count
//var count = students.Count(s=> s.Age == 20);
//Console.WriteLine(count);
#endregion

#region Take, Skip, TakeLast, SkipLast, SkipWhile, TakeWhile
//var studs = students.Skip(3).Take(5).ToList();
//studs.ForEach(Console.WriteLine);


//var studs = students.TakeWhile(s=> s.Age < 35).ToList();
//studs.ForEach(Console.WriteLine);

#endregion

#region All, Any
//var check = students.All(s => s.Age > 35);
//Console.WriteLine(check);
//Console.WriteLine(students.Any(s => s.Age > 35));
#endregion

#region Join, GroupJoin
//var result = groups.Join(students,
//                            g => g.Id,
//                            s => s.GroupId,
//                            (g, s) => new
//                            {
//                                FirstName = s.FirstName,
//                                LastName = s.LastName,
//                                Age = s.Age,
//                                GroupName = g.Name
//                            });

//foreach (var student in result)
//{
//    Console.WriteLine($"{student.FirstName} {student.LastName} - {student.GroupName}");
//}

var resultGroup = groups.GroupJoin(students,
                            g => g.Id,
                            s => s.GroupId,
                            (g, s) => new
                            {
                                GroupName = g.Name,
                                Students = s
                            });

foreach (var group in resultGroup)
{
    Console.WriteLine(group.GroupName);
    foreach (var student in group.Students)
    {
        Console.WriteLine($"\t{student.FirstName} {student.LastName} - {student.Age}");
    }
}
#endregion