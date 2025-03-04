namespace ShoppingSpree;

class Program
{
    static void Main()
    {
        try
        {
            List<Person> persons = ReadPersons();
            List<Product> products = ReadProducts();
            string command;
            while ((command = Console.ReadLine()!) != "END")
            {
                string[] data = command.Split(" ");
                Person person = persons.FirstOrDefault(p => p.Name == data[0])!;
                Product product = products.FirstOrDefault(p => p.Name == data[1])!;
                if (person is null || product is null)
                {
                    throw new ArgumentNullException($"names cannot be null!");
                }
                if (person.BuyProduct(product))
                {
                    Console.WriteLine($"{data[0]} bought {data[1]}");
                }
                else
                {
                    Console.WriteLine($"{data[0]} can't afford {data[1]}");
                }
            }

            foreach (Person currentPerson in persons)
            {
                if (currentPerson.BagOfProducts.Count > 0)
                {
                    Console.WriteLine(
                        $"{currentPerson.Name} - {string.Join(", ", currentPerson.BagOfProducts.Select(p => p.Name))}");
                    continue;
                }
                Console.WriteLine($"{currentPerson.Name} - Nothing bought");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }
    }

    public static List<Person> ReadPersons()
    {
        List<Person> persons = new List<Person>();
        string input = Console.ReadLine()!;
        string[] personInfo = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < personInfo.Length; i++)
        {
            string[] data = personInfo[i].Split("=");
            Person person = new Person(data[0], decimal.Parse(data[1]));
            persons.Add(person);
        }

        return persons;
    }

    public static List<Product> ReadProducts()
    {
        List<Product> products = new List<Product>();
        string input = Console.ReadLine()!;
        string[] productInfo = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
        for (int i = 0; i < productInfo.Length; i++)
        {
            string[] data = productInfo[i].Split("=");
            Product product = new Product(data[0], decimal.Parse(data[1]));
            products.Add(product);
        }

        return products;
    }
}