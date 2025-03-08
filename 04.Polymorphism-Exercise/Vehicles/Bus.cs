namespace Vehicles;

public class Bus : Vehicle
{
    private const double FuelConsumptionModifier = 1.4;
    public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity) 
        : base(fuelQuantity, fuelConsumption + FuelConsumptionModifier, tankCapacity)
    {
    }

    public bool DriveEmptyBus(double distance)
    {
        double originalConsumption = this.FuelConsumption;
        this.FuelConsumption -= FuelConsumptionModifier; 

        bool canTravel = this.Drive(distance);

        this.FuelConsumption = originalConsumption; 

        return canTravel;
    }
    public override void Refuel(double fuelAmount)
    {
        base.Refuel(fuelAmount);
        this.FuelQuantity += fuelAmount;
    }
}