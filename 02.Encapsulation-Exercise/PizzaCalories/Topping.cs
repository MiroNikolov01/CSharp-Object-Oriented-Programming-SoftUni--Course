using System.Diagnostics;

namespace PizzaCalories;

public class Topping
{
    private readonly Dictionary<string, double> _toppingModifiers =
        new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            ["meat"] = 1.2,
            ["veggies"] = 0.8,
            ["cheese"] = 1.1,
            ["sauce"] = 0.9,
        };

    private string toppingType;
    private double grams;

    public string ToppingType
    {
        get => this.toppingType;
        private set
        {
            if (!this._toppingModifiers.ContainsKey(value))
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            this.toppingType = value;
        }
    }

    public double Grams
    {
        get => this.grams;
        private set
        {
            if (value < 1 || value > 50)
                throw new ArgumentException($"{this.ToppingType} weight should be in the range [1..50].");
            this.grams = value;
        }
    }

    public double Calories { get; private set; }

    public Topping(string toppingType, double grams)
    {
        this.ToppingType = toppingType;
        this.Grams = grams;
        this.Calories = 2 * this._toppingModifiers[toppingType] * grams;
    }
}