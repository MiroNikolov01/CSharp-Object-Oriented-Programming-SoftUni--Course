using System.Text;
using WildFarm.AnimalFood;
using WildFarm.Animals.Bird;
using WildFarm.Animals.Feline;
using WildFarm.Animals.Mammal;

namespace WildFarm.Animals;

public abstract class Animal
{
    public string? Type { get; protected set; }
    public string? Name { get; protected set; }
    public double Weight { get;  protected set; }
    public double FoodEaten { get;  protected set; }
    protected abstract double WeightIncreasePerFood();
    protected abstract bool Eat(Food food);

    public bool CanEatFood(Food food)
    {
        if(!this.Eat(food)) return false;
        
        this.Weight += food.Quantity * WeightIncreasePerFood();
        this.FoodEaten += food.Quantity;
        
        return true;
    }

    public virtual string ProduceSound()
    {
        return $"{this.GetType().Name} cannot produce sound from this instance!";
    }
}