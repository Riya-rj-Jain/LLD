using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;


namespace Services.ParkingLot.API.Data.Repositories
{
    public class FloorRepository : IFloorInterface
    {
        private readonly ParkingLotDbContext _context;

        public FloorRepository(ParkingLotDbContext context)
        {
            _context = context;
        }

        public async Task<FloorViewModel> AddFloor(FloorViewModel model)
        {
            var floor = new Floor
            {
                Floor_number = model.Floor_number,
                numberOfSlots = model.numberOfSlots
            };

            await _context.Floors.AddAsync(floor);
            await _context.SaveChangesAsync();

            model.FloorId = floor.FloorId;
            return model;
        }

        public async Task<FloorViewModel> UpdateFloor(FloorViewModel model)
        {
            var floor = await _context.Floors.FindAsync(model.FloorId);
            if (floor == null) return null;

            floor.Floor_number = model.Floor_number;
            floor.numberOfSlots = model.numberOfSlots;

            _context.Floors.Update(floor);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<bool> DeleteFloor(int floorId)
        {
            var floor = await _context.Floors.FindAsync(floorId);
            if (floor == null) return false;

            _context.Floors.Remove(floor);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
