using WildFarm.AnimalFood;

namespace WildFarm.Animals.Bird;

public class Owl : Bird
{
    protected override double WeightIncreasePerFood() => 0.25;
    protected override bool Eat(Food food) => food is Meat;

    public Owl(string type, string name, double weight, double wingSize)
        : base(type, name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Hoot Hoot";
    }
}