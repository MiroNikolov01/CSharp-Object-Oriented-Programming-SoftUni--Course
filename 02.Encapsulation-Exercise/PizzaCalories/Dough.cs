namespace PizzaCalories;

public class Dough
{
    private readonly Dictionary<string, double> _flourModifiers =
        new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            ["white"] = 1.5,
            ["wholegrain"] = 1.0,
        };

    private readonly Dictionary<string, double> _bakingModifiers =
        new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            ["crispy"] = 0.9,
            ["chewy"] = 1.1,
            ["homemade"] = 1.0,
        };

    private string flourType;
    private string bakingTechnique;
    private double grams;

    public string FlourType
    {
        get => flourType;
        private set
        {
            if(!this._flourModifiers.ContainsKey(value))
                throw new ArgumentException($"Invalid type of dough.");
            flourType = value;
        }
    }

    public string BakingTechnique
    {
        get => bakingTechnique;
        private set
        {
            if(!this._bakingModifiers.ContainsKey(value))
                throw new ArgumentException($"Invalid type of dough.");
            bakingTechnique = value;
        }
    }

    public double Grams
    {
        get => grams;
        private set
        {
            if(value < 1 || value > 200) 
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            grams = value;
        }
    }
    public double Calories { get; private set; }

    public Dough(string flourType, string bakingTechnique, double grams)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Grams = grams;
        this.Calories = 2 * grams * this._flourModifiers[flourType] * this._bakingModifiers[bakingTechnique];
    }
}