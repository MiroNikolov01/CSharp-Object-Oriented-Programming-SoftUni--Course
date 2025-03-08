using WildFarm.AnimalFood;

namespace WildFarm.Animals.Mammal;

public class Mouse : Mammal
{
    protected override double WeightIncreasePerFood() => 0.10;
    protected override bool Eat(Food food) => food is Vegetable || food is Fruit;

    public Mouse(string type, string name, double weight, string livingRegion) 
        : base(type, name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Squeak";
    }
}