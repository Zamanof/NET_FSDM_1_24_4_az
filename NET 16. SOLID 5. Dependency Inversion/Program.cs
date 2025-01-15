Postgree postgree = new();
Application application = new(new JSONSerialization());
application.CRUD();
#region Dependency Inversion - Bad Example

//class MSSQL
//{
//    public void Create() => Console.WriteLine("Create With MSSQL");
//    public void Read() => Console.WriteLine("Read With MSSQL");
//    public void Update() => Console.WriteLine("Update With MSSQL");
//    public void Delete() => Console.WriteLine("Delete With MSSQL");
//}

//class MySQL
//{
//    public void Create() => Console.WriteLine("Create With MySQL");
//    public void Read() => Console.WriteLine("Read With MySQL");
//    public void Update() => Console.WriteLine("Update With MySQL");
//    public void Delete() => Console.WriteLine("Delete With MySQL");
//}

//class Postgree
//{
//    public void Create() => Console.WriteLine("Create With Postgree");
//    public void Read() => Console.WriteLine("Read With Postgree");
//    public void Update() => Console.WriteLine("Update With Postgree");
//    public void Delete() => Console.WriteLine("Delete With Postgree");
//}

//class Application
//{
//    private Postgree _db;

//    public Application(Postgree db)
//    {
//        _db = db;
//    }

//    public void CRUD()
//    {
//        _db.Create();
//        _db.Update();
//        _db.Read();
//        _db.Delete();
//    }
//}

#endregion


#region Dependency Inversion - Bad Example

interface IDb
{
    void Create();
    void Read();
    void Update();
    void Delete();

}
class MSSQL : IDb
{
    public void Create() => Console.WriteLine("Create With MSSQL");
    public void Read() => Console.WriteLine("Read With MSSQL");
    public void Update() => Console.WriteLine("Update With MSSQL");
    public void Delete() => Console.WriteLine("Delete With MSSQL");
}

class MySQL: IDb
{
    public void Create() => Console.WriteLine("Create With MySQL");
    public void Read() => Console.WriteLine("Read With MySQL");
    public void Update() => Console.WriteLine("Update With MySQL");
    public void Delete() => Console.WriteLine("Delete With MySQL");
}

class Postgree : IDb
{
    public void Create() => Console.WriteLine("Create With Postgree");
    public void Read() => Console.WriteLine("Read With Postgree");
    public void Update() => Console.WriteLine("Update With Postgree");
    public void Delete() => Console.WriteLine("Delete With Postgree");
}

class JSONSerialization : IDb
{
    public void Create() => Console.WriteLine("Create With JSONSerialization");
    public void Read() => Console.WriteLine("Read With JSONSerialization");
    public void Update() => Console.WriteLine("Update With JSONSerialization");
    public void Delete() => Console.WriteLine("Delete With JSONSerialization");
}

class Application
{
    private IDb _db;

    public Application(IDb db)
    {
        _db = db;
    }

    public void CRUD()
    {
        _db.Create();
        _db.Update();
        _db.Read();
        _db.Delete();
    }
}

#endregion
