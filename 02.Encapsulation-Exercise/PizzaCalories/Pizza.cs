namespace PizzaCalories;

public class Pizza
{
    private string name;
    private readonly List<Topping> toppings;
    public string Name
    {
        get => this.name;
        private set
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length > 15 || value.Length < 1)
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            this.name = value;
        }
    }

    public IReadOnlyCollection<Topping> Toppings { get; }
    public Dough Dough { get; set; }

    public double TotalCalories => toppings.Sum(x => x.Calories) + Dough.Calories;

    public Pizza(string name)
    {
        this.Name = name;
        this.toppings = new List<Topping>();
        this.Toppings = this.toppings.AsReadOnly();
    }

    public int CountToppings => this.toppings.Count;

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
        if (CountToppings > 10)
        {
            throw new Exception("Number of toppings should be in range [0..10].");
        }
    }
}