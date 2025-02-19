namespace NeedForSpeed;

public class StartUp
{
    static void Main(string[] args)
    {
        Vehicle vehicle = new Vehicle(250, 400);
        SportCar sportCar = new SportCar(500, 1300);
        RaceMotorcycle raceMotorcycle = new RaceMotorcycle(500, 1300);
        Car car = new Car(250, 400);
        FamilyCar familyCar = new FamilyCar(500, 1300);
        CrossMotorcycle crossMotorcycle = new CrossMotorcycle(500, 1300);

        Console.WriteLine(car.FuelConsumption);
        
        Console.WriteLine(sportCar.FuelConsumption);
        Console.WriteLine(familyCar.FuelConsumption);
        Console.WriteLine(crossMotorcycle.FuelConsumption);
        Console.WriteLine(raceMotorcycle.FuelConsumption);
        
        
    }
}