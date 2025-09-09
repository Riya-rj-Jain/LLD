using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;


namespace Services.ParkingLot.API.Interfaces
{
    public interface SlotInterface
    {
        Task<SlotViewModel> AddSlot(SlotViewModel slot);
        Task<SlotViewModel> UpdateSloot(SlotViewModel slot);
        Task<bool> DeleteSlot(int SlotId);
        Task<(int SlotId, int FloorId)?> GetAvailableSlotAsync(int vehicleTypeId);

        Task<bool> UpdateSlotAvailability(int SlotId, bool isOccupied);
    }
}
