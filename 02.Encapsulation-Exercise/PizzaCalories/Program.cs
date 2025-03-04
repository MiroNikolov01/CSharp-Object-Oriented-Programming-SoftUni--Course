namespace PizzaCalories;

class Program
{
    static void Main(string[] args)
    {
        List<Pizza> pizzas = new List<Pizza>();
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] data = command.Split(" ");
            try
            {
                switch (data[0])
                {
                    case "Pizza":
                    {
                        Pizza pizza = new Pizza(data[1]);
                        pizzas.Add(pizza);
                        break;
                    }
                    case "Dough":
                    {
                        pizzas[0].Dough = new Dough(data[1], data[2], double.Parse(data[3]));
                        break;
                    }
                    case "Topping":
                    {
                        pizzas[0].AddTopping(new Topping(data[1],double.Parse(data[2])));
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(0);
            }
        }

        Console.WriteLine($"{pizzas[0].Name} - {pizzas[0].TotalCalories:F2} Calories.");
        
    }
}