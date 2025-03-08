namespace Vehicles.Abstraction;

public interface IVehicle
{
    bool Drive(double distance);
    void Refuel(double fuelAmount);
}