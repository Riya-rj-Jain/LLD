using Services.ParkingLot.API.Models.Entities;


namespace Services.ParkingLot.API.Interfaces
{
    public interface SlotInterface
    {
        Task AddSlot(Slot slot);
        Task UpdateSloot(Slot slot);
        Task<bool> DeleteSlot(int SlotId);
    }
}
