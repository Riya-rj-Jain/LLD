using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Services
{
    public class FloorService
    {
        private readonly IFloorInterface _floorRepository;

        public FloorService(IFloorInterface floorRepository)
        {
            _floorRepository = floorRepository;
        }

        public async Task<FloorViewModel> AddFloor(FloorViewModel model)
        {
            return await _floorRepository.AddFloor(model);
        }
    }
}
