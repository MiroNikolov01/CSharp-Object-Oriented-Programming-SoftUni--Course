namespace Animals;

public class StartUp
{
    static void Main(string[] args)
    {
        HashSet<string> animals = new HashSet<string>()
        {
            "Cat",
            "Dog",
            "Frog",
            "Tomcat",
            "Kittens"
        };
        string currentAnimal = string.Empty;
        string command;
        while ((command = Console.ReadLine()) != "Beast!")
        {
            if (animals.Contains(command))
            {
                currentAnimal = command;
                continue;
            }
            try
            {
                string[] animalData = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = animalData[0];
                int age = int.Parse(animalData[1]);
                if (age < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }

                string gender = animalData[2];

                Animal animal = currentAnimal switch
                {
                    "Cat" => new Cat(name, age, gender),
                    "Dog" => new Dog(name, age, gender),
                    "Frog" => new Frog(name, age, gender),
                    "Tomcat" => new Tomcat(name, age),
                    "Kittens" => new Kitten(name, age),
                    _ => throw new ArgumentException("Invalid input!")
                };
                
                Console.WriteLine(animal);
                Console.WriteLine(animal.ProduceSound());
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}