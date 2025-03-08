using WildFarm.AnimalFood;

namespace WildFarm.Animals.Mammal;

public class Dog : Mammal
{
    protected override double WeightIncreasePerFood() => 0.40;
    protected override bool Eat(Food food) => food is Meat;

    public Dog(string type, string name, double weight, string livingRegion)
        : base(type, name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }
}