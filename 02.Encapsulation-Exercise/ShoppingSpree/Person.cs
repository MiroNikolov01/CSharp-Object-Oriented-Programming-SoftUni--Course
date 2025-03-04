namespace ShoppingSpree;

public class Person
{
    private string _name;
    private decimal _money;
    private readonly List<Product> _bagOfProducts;

    public string Name
    {
        get => this._name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name cannot be empty");
            this._name = value;
        }
    }

    public decimal Money
    {
        get => this._money;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Money cannot be negative");
            this._money = value;
        }
    }

    public IReadOnlyList<Product> BagOfProducts { get; }

    public Person(string name, decimal money)
    {
        this.Name = name;
        this.Money = money;
        this._bagOfProducts = new List<Product>();
        this.BagOfProducts = this._bagOfProducts.AsReadOnly();
    }

    public bool BuyProduct(Product product)
    {
        if (this.Money >= product.Cost)
        {
            this._bagOfProducts.Add(product);
            this.Money -= product.Cost;
            return true;
        }
        return false;
    }
}