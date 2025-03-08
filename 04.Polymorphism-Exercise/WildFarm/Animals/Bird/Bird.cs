namespace WildFarm.Animals.Bird;

public abstract class Bird : Animal
{
    public double WingSize { get; }
 

    public Bird(string type, string name, double weight, double wingSize)
    {
        this.Type = type;
        this.Name = name;
        this.Weight = weight;
        this.WingSize = wingSize;
    }

    public override string ToString()
    {
        return $"{this.Type} [{this.Name}, {WingSize}, {this.Weight}, {FoodEaten}]";
    }
}