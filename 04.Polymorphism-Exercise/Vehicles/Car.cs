using System.Runtime.CompilerServices;

namespace Vehicles;

public class Car : Vehicle
{
    private const double FuelConsumptionModifier = 0.9;
    public Car(double fuelQuantity, double fuelConsumption,double tankCapacity) 
        : base(fuelQuantity, fuelConsumption + FuelConsumptionModifier,tankCapacity)
    {
    }

    public override void Refuel(double fuelAmount)
    {
        base.Refuel(fuelAmount);
        this.FuelQuantity += fuelAmount;
    }
}