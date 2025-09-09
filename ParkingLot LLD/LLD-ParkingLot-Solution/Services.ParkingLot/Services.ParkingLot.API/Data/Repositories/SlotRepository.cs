
using Microsoft.EntityFrameworkCore;
using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Data.Repositories
{
    public class SlotRepository : SlotInterface
    {
        private readonly ParkingLotDbContext _context;

        public SlotRepository(ParkingLotDbContext context)
        {
            _context = context;
        }
        public async Task<SlotViewModel> AddSlot(SlotViewModel slot)
        {
            var newslot = new Slot
            {
                SlotId = slot.SlotId,
                SlotName = slot.SlotName,
                IsOccupied = slot.IsOccupied,
                FloorId = slot.FloorId,
                VehicleTypeId = slot.VehicleTypeId,
            };
            _context.Slot.Add(newslot);
            await _context.SaveChangesAsync();
            return slot;
        }

        public async Task<bool> DeleteSlot(int SlotId)
        {
            var slot = await _context.Slot.FindAsync(SlotId);
            if (slot == null)
            {
                return false;
            }
            _context.Slot.Remove(slot);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<SlotViewModel> UpdateSloot(SlotViewModel slot)
        {
            var existingSlot = await _context.Slot.FindAsync(slot.SlotId);
            if (existingSlot == null)
            {
                return null;
            }

            existingSlot.SlotName = slot.SlotName;
            existingSlot.IsOccupied = slot.IsOccupied;
            existingSlot.FloorId = slot.FloorId;
            existingSlot.VehicleTypeId = slot.VehicleTypeId;

            await _context.SaveChangesAsync();

            return slot;
        }

        public async Task<(int SlotId, int FloorId)?> GetAvailableSlotAsync(int vehicleTypeId)
        {
            var slot = await _context.Slot
                .Where(s => s.VehicleTypeId == vehicleTypeId && !s.IsOccupied)
                .FirstOrDefaultAsync();

            if (slot == null)
                return null;

            return (slot.SlotId, slot.FloorId);
        }

        public async Task<bool> UpdateSlotAvailability(int SlotId, bool isOccupied)
        {
            var existingSlot = await _context.Slot.FindAsync(SlotId);
            if (existingSlot == null)
            {
                return false;
            }
            existingSlot.IsOccupied = isOccupied;


            await _context.SaveChangesAsync();

            return true;
        }
    }
}
