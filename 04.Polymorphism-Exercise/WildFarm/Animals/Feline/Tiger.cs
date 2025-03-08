using WildFarm.AnimalFood;

namespace WildFarm.Animals.Feline;

public class Tiger : Feline
{
    protected override double WeightIncreasePerFood() => 1.00;
    protected override bool Eat(Food food) => food is Meat;

    public Tiger(string type, string name, double weight, string livingRegion, string breed)
        : base(type, name, weight, livingRegion, breed)
    {
    }

    public override string ProduceSound()
    {
        return "ROAR!!!";
    }
}