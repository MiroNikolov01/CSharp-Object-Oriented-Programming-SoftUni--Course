using WildFarm.AnimalFood;

namespace WildFarm.Animals.Feline;

public class Cat : Feline
{
    protected override double WeightIncreasePerFood() => 0.30;
    protected override bool Eat(Food food) => food is Vegetable || food is Meat;

    public Cat(string type, string name, double weight, string livingRegion, string breed)
        : base(type, name, weight, livingRegion, breed)
    {
    }

    public override string ProduceSound()
    {
        return "Meow";
    }
}