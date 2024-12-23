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
}