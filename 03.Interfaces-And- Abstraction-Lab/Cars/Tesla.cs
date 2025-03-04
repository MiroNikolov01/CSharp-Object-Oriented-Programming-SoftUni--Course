namespace Cars;

public class Tesla : Car, IElectricCar
{
    public int Battery { get; set; }

    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }

    public override string ToString()
    {
        return $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries";
    }
}