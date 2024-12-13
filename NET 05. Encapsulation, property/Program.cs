Human human = new();
//human.SetAge(-25);
//Console.WriteLine(human.GetAge());
//human.Name = "Nadir";
//Console.WriteLine(human.Name);
//Console.WriteLine(human.Surname);
//human.Surname = "Salam";
//Console.WriteLine(human.GroupName);
human.Age = 125;
Console.WriteLine(human.Age);

class Human
{
    // auto property
    public string Name { get; set; }
    public string Surname { get; } = "Doe";
    public string GroupName { private get; set; } = "FSDM_1_24_4_az";
    private int age;
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 150)
                throw new ArgumentOutOfRangeException("Out of Range 0~150");
            age = value;
        }
    }

    //public int get_Age()
    //{
    //    return age;
    //}

    //public void set_Age(int value) { }


    //private int age;

    //public void SetAge(int value)
    //{
    //    if (value < 0) { age = 0; }
    //    else { age = value; }
    //}

    //public int GetAge() => age;
}
