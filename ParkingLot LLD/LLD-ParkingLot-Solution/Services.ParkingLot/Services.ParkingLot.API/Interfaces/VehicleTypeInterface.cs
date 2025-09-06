

namespace Services.ParkingLot.API.Interfaces
{
    public interface VehicleTypeInterface
    {
        Task AddVehicleType(string vehicleType);
        Task UpdateVehicleType(int vehicleTypeId, string vehicleType);
        Task<bool> DeleteVehicleType(int vehicleTypeId);
    }
}
