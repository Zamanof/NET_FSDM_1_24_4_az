
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

Teacher teacher = new Teacher();
foreach (Student student in students)
{
    teacher.examEvent += student.Exam;
}

Student student1 = new Student() { FirstName = "Lamina", LastName = "Tac", Age = 36 };

teacher.examEvent += student1.Exam;
teacher.Exam("Make Site");
Console.WriteLine();
teacher.examEvent -= student1.Exam;
teacher.Exam("Write calculator");

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public void Exam(string task)
    {
        if (Age < 18)
        {
            Console.WriteLine($"{FirstName} {LastName} not solved {task}");
        }
        else
        {
            Console.WriteLine($"{FirstName} {LastName} solved {task}");
        }
    }
}

class Teacher
{
    SortedList<int, ExamDelegate> _sortedEvents = new SortedList<int, ExamDelegate>();
    Random _random = new Random();
    public event ExamDelegate examEvent
    {
        add
        {
            for (int key = 0; ;)
            {
                key = _random.Next();
                if (!_sortedEvents.ContainsKey(key))
                {
                    _sortedEvents.Add(key, value);
                    break;
                }
            }
        }
        remove
        {
            _sortedEvents.RemoveAt(_sortedEvents.IndexOfValue(value));
        }
    }
    public void Exam(string task)
    {
        foreach (int key in _sortedEvents.Keys)
        {
            if (_sortedEvents[key] is not null)
            {
                _sortedEvents[key].Invoke(task);
            }
        }
    }
}
public delegate void ExamDelegate(string Task);