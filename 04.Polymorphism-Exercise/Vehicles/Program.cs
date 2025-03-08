using Vehicles.Abstraction;

namespace Vehicles;

class Program
{
    static void Main(string[] args)
    {
        const int countVehicles = 3;

        Dictionary<string, Vehicle> vehiclesMap = new();

        for (int i = 0; i < countVehicles; i++)
        {
            string[] vehicleData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string type = vehicleData[0];
            double fuel = double.Parse(vehicleData[1]);
            double consumption = double.Parse(vehicleData[2]);
            double capacity = double.Parse(vehicleData[3]);

            vehiclesMap[type] = CreateVehicle(type, fuel, consumption, capacity);
        }

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string vehicleType = command[1];
            if (vehiclesMap.ContainsKey(vehicleType))
            {
                double distance = double.Parse(command[2]);
                Vehicle vehicle = vehiclesMap[vehicleType];
                switch (command[0])
                {
                    case "Drive":
                        if (!vehicle.Drive(distance))
                        {
                            Console.WriteLine($"{vehiclesMap[vehicleType].GetType().Name} needs refueling");
                            continue;
                        }

                        Console.WriteLine($"{vehiclesMap[vehicleType].GetType().Name} travelled {distance} km");

                        break;
                    case "Refuel":
                        try
                        {
                            double fuelAmount = double.Parse(command[2]);
                            vehicle.Refuel(fuelAmount);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "DriveEmpty":
                        if (vehicle is Bus bus)
                            if (!bus.DriveEmptyBus(distance))
                            {
                                Console.WriteLine($"{bus.GetType().Name} needs refueling");
                            }
                            else
                            {
                                Console.WriteLine($"{bus.GetType().Name} travelled {distance} km");
                            }

                        break;
                }
            }
        }

        foreach (var (vehicleType, value) in vehiclesMap)
        {
            Console.WriteLine($"{vehicleType}: {value.FuelQuantity:F2}");
        }
    }

    private static Vehicle CreateVehicle(string type, double fuel, double consumption, double capacity)
    {
        if (fuel > capacity) fuel = 0;

        return type switch
        {
            "Car" => new Car(fuel, consumption, capacity),
            "Truck" => new Truck(fuel, consumption, capacity),
            "Bus" => new Bus(fuel, consumption, capacity),
            _ => throw new ArgumentException("Invalid vehicle type")
        };
    }
}