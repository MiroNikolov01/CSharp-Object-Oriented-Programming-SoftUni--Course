using System.Runtime.CompilerServices;
using WildFarm.AnimalFood;
using WildFarm.Animals;
using WildFarm.Animals.Bird;
using WildFarm.Animals.Feline;
using WildFarm.Animals.Mammal;

namespace WildFarm;

class Program
{
    static void Main()
    {
        List<Animal> animals = new List<Animal>();
        Animal? animal = null;
        string command = string.Empty;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] data = command
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            if (data.Length > 2)
            {
                animal = data[0] switch
                {
                    "Cat" => new Cat(data[0], data[1], double.Parse(data[2]), data[3], data[4]),
                    "Tiger" => new Tiger(data[0], data[1], double.Parse(data[2]), data[3], data[4]),
                    "Hen" => new Hen(data[0], data[1], double.Parse(data[2]), double.Parse(data[3])),
                    "Owl" => new Owl(data[0], data[1], double.Parse(data[2]), double.Parse(data[3])),
                    "Mouse" => new Mouse(data[0], data[1], double.Parse(data[2]), data[3]),
                    "Dog" => new Dog(data[0], data[1], double.Parse(data[2]), data[3]),
                    _ => null
                };
                if (animal is not null)
                {
                    Console.WriteLine(animal.ProduceSound());
                }

                animals.Add(animal);
            }
            else if (data.Length == 2)
            {
                int foodQuantity = int.Parse(data[1]);
                Food? food = data[0] switch
                {
                    "Vegetable" => new Vegetable(foodQuantity),
                    "Fruit" => new Fruit(foodQuantity),
                    "Meat" => new Meat(foodQuantity),
                    "Seeds" => new Seeds(foodQuantity),
                    _ => null
                };
                if (food is not null)
                {
                    if (!animal.CanEatFood(food))
                    {
                        Console.WriteLine($"{animal.GetType().Name} does not eat {food.GetType().Name}!");
                    }
                }
            }
        }
        foreach (var currentAnimal in animals)
        {
            Console.WriteLine(currentAnimal.ToString());
        }
    }
}