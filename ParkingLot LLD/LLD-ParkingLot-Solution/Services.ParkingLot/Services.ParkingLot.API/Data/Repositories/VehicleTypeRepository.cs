using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.Entities;


namespace Services.ParkingLot.API.Data.Repositories
{
    public class VehicleTypeRepository : VehicleTypeInterface
    {
        private readonly ParkingLotDbContext _context;

        public VehicleTypeRepository(ParkingLotDbContext context)
        {
            _context = context;
        }
        public async Task AddVehicleType(string vehicleType)
        {
            var entity = new VehicleType { VehicleName = vehicleType };
            _context.VehicleType.Add(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVehicleType(int vehicleTypeId, string vehicleType)
        {
            var entity = await _context.VehicleType.FindAsync(vehicleTypeId);
            if (entity != null)
            {
                entity.VehicleName = vehicleType;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<bool> DeleteVehicleType(int vehicleTypeId)
        {
            var entity = await _context.VehicleType.FindAsync(vehicleTypeId);
            if (entity != null)
            {
                _context.VehicleType.Remove(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}
