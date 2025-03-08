using Vehicles.Abstraction;

namespace Vehicles;

public abstract class Vehicle : IVehicle
{
    public double FuelQuantity { get; set; }
    protected double FuelConsumption { get; set; }
    public double TankCapacity { get; set; }

    protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity > tankCapacity ? 0 : fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }

    public bool Drive(double distance)
    {
        double neededFuel = distance * this.FuelConsumption;
        if (this.FuelQuantity < neededFuel)
        {
            return false;
        }

        this.FuelQuantity -= neededFuel;
        return true;
    }

    public virtual void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }

        if (fuelAmount + this.FuelQuantity > this.TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
        }
    }
}