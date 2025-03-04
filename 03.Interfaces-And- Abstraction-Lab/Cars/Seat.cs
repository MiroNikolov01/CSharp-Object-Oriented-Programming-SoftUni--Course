namespace Cars;

public class Seat : Car 
{
    public Seat(string model, string color)
    {
        this.Model = model;
        this.Color = color;
    }

    public override string ToString()
    {
        return $"{this.Color} Seat {this.Model}";
    }
}