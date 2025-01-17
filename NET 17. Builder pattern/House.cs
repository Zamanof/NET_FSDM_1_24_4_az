namespace NET_17._Builder_pattern;

internal class House
{
    public string? Name { get; set; }
    public int Walls { get; set; }
    public int Door { get; set; }
    public int Window { get; set; }
    public int Pool { get; set; }
    public int Garage { get; set; }
    public int Garden { get; set; }

    public bool HasRoof {  get; set; }

    public override string ToString()
    {
        return @$"
Name: {Name}
Walls: {Walls}
Doors: {Door}
Windows: {Window}
Garage: {Garage}
Pool: {Pool}
Garden: {Garden}
Roof: {(HasRoof?"Has roof": "Without roof")}";
    }
}
