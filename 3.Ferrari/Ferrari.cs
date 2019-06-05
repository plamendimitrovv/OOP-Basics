

public class Ferrari : ICar
{
    public Ferrari(string driverName)
    {
        DriverName = driverName;
        this.Model = "488-Spider";
    }

    public string DriverName { get; set; }
    public string Model { get; set; }

    public string GasPedal()
    {
        return ("Zadu6avam sA!");
    }

    public string UseBrakes()
    {
        return ("Brakes");
    }

    public string ToStirng()
    {
        return $"{this.Model}/{this.UseBrakes()}/{this.GasPedal()}/{this.DriverName}";
    }
}

