using Services.ParkingLot.API.Models.Entities;

namespace Services.ParkingLot.API.Interfaces
{
    public interface IFloorService
    {
        Task AddFloor(Floor floor);
        Task UpdateFloor(Floor floor);
        Task<bool> DeleteFloor(int floorId);
    }

}
