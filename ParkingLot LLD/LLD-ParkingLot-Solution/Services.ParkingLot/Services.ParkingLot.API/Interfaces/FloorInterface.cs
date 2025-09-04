using Services.ParkingLot.API.Models.Entities;

namespace Services.ParkingLot.API.Interfaces
{
    public interface IFloorService
    {
        Task<bool> AddFloor(Floor floor);
        Task<bool> UpdateFloor(Floor floor);
        Task<bool> DeleteFloor(int floorId);
    }

}
