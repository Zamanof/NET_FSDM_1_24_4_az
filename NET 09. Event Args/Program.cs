
List<Student> students = new()
{
    new Student(){FirstName = "Ala", LastName="Bula", Age = 18 },
    new Student(){FirstName = "Hi", LastName="Hello", Age = 25 },
    new Student(){FirstName = "Yuliya", LastName="Sezarova", Age = 118 },
    new Student(){FirstName = "Napolenixa", LastName="Bonopartich", Age = 180 },
    new Student(){FirstName = "Slonixa", LastName="Indiyskaya", Age = 9 },
    new Student(){FirstName = "Bubba", LastName="Tubba", Age = 13 },
    new Student(){FirstName = "Simba", LastName="ibn Mufasa", Age = 7 },
    new Student(){FirstName = "Timon", LastName="Timon", Age = 18 },
    new Student(){FirstName = "Pumba", LastName="Pumba", Age = 18 },
    new Student(){FirstName = "Hakuna", LastName="Matata", Age = 42 }
};

Teacher teacher = new Teacher() { FirstName = "Nadir" };
Teacher teacher1 = new Teacher() { FirstName = "Namig" };

for (int i = 0; i < students.Count; i++)
{
    if (i % 2 == 0) teacher.examEvent += students[i].Exam;
    else teacher1.examEvent += students[i].Exam;
}


ExamEventArgs examEventArgs = new ExamEventArgs { Task = "Write kalkulyator" };
teacher.Exam(examEventArgs);
teacher1.Exam(new ExamEventArgs { Task = "Make site" });

class Student
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public int Age { get; set; }
    public void Exam(object sender, ExamEventArgs args)
    {
        Console.WriteLine($"{(sender as Teacher)?.FirstName} send Task");
        if (Age < 18)
        {
            Console.WriteLine($"{FirstName} {LastName} not solved {args.Task}");
        }
        else
        {
            Console.WriteLine($"{FirstName} {LastName} solved {args.Task}");
        }
    }
}

class Teacher
{
    public string FirstName { get; set; }
    public EventHandler<ExamEventArgs> examEvent;
    public void Exam(ExamEventArgs args)
    {
        examEvent(this, args);
    }
}

class ExamEventArgs : EventArgs
{
    public string Task { get; set; }
}