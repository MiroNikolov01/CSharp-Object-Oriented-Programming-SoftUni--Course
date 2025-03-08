namespace WildFarm.Animals.Mammal;

public abstract class Mammal : Animal
{
    public string LivingRegion { get; protected set; }

    public Mammal(string type, string name, double weight, string livingRegion)
    {
        this.Type = type;
        this.Name = name;
        this.Weight = weight;
        this.LivingRegion = livingRegion;
    }

    public override string ToString()
    {
        return $"{this.Type} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}