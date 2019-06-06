

public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        DriverName = driverName;
        Model = "488-Spider";
    }

    public Ferrari()
    {
    }

    public string DriverName { get; set; }
    public string Model { get; set; }

    public string GasPedal()
    {
        return "Zadu6avam sA!";
    }

    public string UseBrakes()
    {
        return "Brakes!";
    }

    public override string ToString()
    {
        return $"{this.Model}/{this.UseBrakes()}/{this.GasPedal()}/{this.DriverName}";
    }
}

