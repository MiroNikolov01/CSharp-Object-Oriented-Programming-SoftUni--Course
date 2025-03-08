using System.Data.SqlTypes;
using WildFarm.AnimalFood;

namespace WildFarm.Animals.Bird;

public class Hen : Bird
{
    protected override double WeightIncreasePerFood() => 0.35;
    protected override bool Eat(Food food) => true;

    public Hen(string type, string name, double weight, double wingSize)
        : base(type, name, weight, wingSize)
    {
    }

    public override string ProduceSound()
    {
        return "Cluck";
    }
}