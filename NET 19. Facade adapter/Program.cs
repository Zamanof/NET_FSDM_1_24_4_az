// Facade adapter
ComputerFacade facade = new ComputerFacade();
facade.Start();
interface IDevice
{ 
    string? Vendor { get; set; }
    string? Model { get; set; }
    void Start();
}

class CPU : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("CPU Started");
    }
}

class RAM : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("RAM Started");
    }
}

class GPU : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("GPU Started");
    }
}

class Motherboard : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("Motherboard Started");
    }
}

class PowerSupply : IDevice
{
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Console.WriteLine("PowerSupply Started");
    }
}

class Case: IDevice
{
    private List<IDevice> Devices { get; set; } = new();
    public string? Vendor { get; set; }
    public string? Model { get; set; }

    public void Start()
    {
        Devices.ForEach(d=>d.Start());
        Console.WriteLine("PC started");
    }
    public void AddDevice(IDevice device)
    {
        Devices.Add(device);
    }
}

class ComputerFacade
{
    private Motherboard motherboard = new();
    private RAM RAM = new();
    private CPU CPU = new();
    private GPU GPU = new();
    private PowerSupply powerSupply = new();
    private Case Case = new();

    public void Start()
    {
        Case.AddDevice(motherboard);
        Case.AddDevice(powerSupply);
        Case.AddDevice(CPU);
        Case.AddDevice(GPU);
        Case.AddDevice(RAM);

        Case.Start();
    }
}