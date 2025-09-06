using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Interfaces
{
    public interface IFloorInterface
    {
        Task<FloorViewModel> AddFloor(FloorViewModel model);
        Task<FloorViewModel> UpdateFloor(FloorViewModel model);
        Task<bool> DeleteFloor(int floorId);
    }

}
