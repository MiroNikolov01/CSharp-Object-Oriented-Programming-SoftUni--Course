namespace WildFarm.Animals.Feline;

public abstract class Feline : Mammal.Mammal
{
    public string Breed { get; protected set; }
    public Feline(string type, string name, double weight, string livingRegion, string breed) 
        : base(type, name, weight, livingRegion)
    {
        this.Type = type;
        this.Name = name;
        this.Weight = weight;
        this.LivingRegion = livingRegion;
        this.Breed = breed;
        
    }
    public override string ToString()
    {
        return $"{this.Type} [{this.Name}, {Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
    }
}