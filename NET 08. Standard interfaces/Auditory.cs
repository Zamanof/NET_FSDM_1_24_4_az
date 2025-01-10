// See https://aka.ms/new-console-template for more information
using System.Collections;

class Auditory : IEnumerable
{
    Student[] students =
    {
        new Student
        {
            FirstName = "Salam",
            LastName = "Salamzade",
            Email = "Salamzade@salam.com",
            BirthDate = new DateTime(2000, 12, 31),
            StudentCard = new StudentCard()
            {
                Id = 136542,
                Series = "AA"

            }
        },
        new Student
        {
            FirstName = "Clark",
            LastName = "Kent",
            Email = "clark.kent@dailyplanet.com",
            BirthDate = new DateTime(1526, 10, 19),
            StudentCard = new StudentCard()
            {
                Id = 100001,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Bruce",
            LastName = "Wayne",
            Email = "bruce.wayne@wayneenterprises.com",
            BirthDate = new DateTime(1970, 2, 19),
            StudentCard = new StudentCard()
            {
                Id = 100002,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Diana",
            LastName = "Prince",
            Email = "diana.prince@themyscira.com",
            BirthDate = new DateTime(1956, 3, 25),
            StudentCard = new StudentCard()
            {
                Id = 100003,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Barry",
            LastName = "Allen",
            Email = "barry.allen@ccpd.com",
            BirthDate = new DateTime(2014, 10, 1),
            StudentCard = new StudentCard()
            {
                Id = 100004,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Hal",
            LastName = "Jordan",
            Email = "hal.jordan@greenlantern.com",
            BirthDate = new DateTime(1949, 9, 19),
            StudentCard = new StudentCard()
            {
                Id = 100005,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Arthur",
            LastName = "Curry",
            Email = "arthur.curry@atlantis.com",
            BirthDate = new DateTime(1917, 3, 3),
            StudentCard = new StudentCard()
            {
                Id = 100006,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Victor",
            LastName = "Stone",
            Email = "victor.stone@cyborg.com",
            BirthDate = new DateTime(1973, 4, 4),
            StudentCard = new StudentCard()
            {
                Id = 100007,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Peter",
            LastName = "Parker",
            Email = "peter.parker@dailybugle.com",
            BirthDate = new DateTime(2001, 8, 10),
            StudentCard = new StudentCard()
            {
                Id = 100008,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Tony",
            LastName = "Stark",
            Email = "tony.stark@starkindustries.com",
            BirthDate = new DateTime(1973, 3, 30),
            StudentCard = new StudentCard()
            {
                Id = 100009,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Steve",
            LastName = "Rogers",
            Email = "steve.rogers@avengers.com",
            BirthDate = new DateTime(1910, 10, 10),
            StudentCard = new StudentCard()
            {
                Id = 100010,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Natasha",
            LastName = "Romanoff",
            Email = "natasha.romanoff@shield.com",
            BirthDate = new DateTime(1970, 4, 14),
            StudentCard = new StudentCard()
            {
                Id = 100011,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Clint",
            LastName = "Barton",
            Email = "clint.barton@shield.com",
            BirthDate = new DateTime(1939, 5, 5),
            StudentCard = new StudentCard()
            {
                Id = 100012,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Wanda",
            LastName = "Maximoff",
            Email = "wanda.maximoff@avengers.com",
            BirthDate = new DateTime(2000, 7, 7),
            StudentCard = new StudentCard()
            {
                Id = 100013,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "Stephen",
            LastName = "Strange",
            Email = "stephen.strange@sorcerersupreme.com",
            BirthDate = new DateTime(1930, 6, 6),
            StudentCard = new StudentCard()
            {
                Id = 100014,
                Series = "AA"
            }
        },
        new Student
        {
            FirstName = "T'Challa",
            LastName = "",
            Email = "tchalla@wakanda.com",
            BirthDate = new DateTime(1980, 10, 7),
            StudentCard = new StudentCard()
            {
                Id = 100015,
                Series = "AA"
            }
        }


    };

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public void Sort()
    {
        Array.Sort(students);
    }

    public void Sort(IComparer comparer)
    {
        Array.Sort(students, comparer);
    }
}