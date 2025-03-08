namespace Vehicles;

public class Truck : Vehicle
{
    private const double FuelConsumptionModifier = 1.6;
    private const double TruckTankLeakage = 0.95;

    public Truck(double fuelQuantity, double fuelConsumption, double tankCapacity)
        : base(fuelQuantity, fuelConsumption + FuelConsumptionModifier, tankCapacity)
    {
    }

    public override void Refuel(double fuelAmount)
    {
        base.Refuel(fuelAmount);
        this.FuelQuantity += fuelAmount * TruckTankLeakage;
    }
}