

namespace Services.ParkingLot.API.Models.ViewModels
{
    public class SlotViewModel
    {
        public int SlotId { get; set; }

        public string? SlotName { get; set; }

        public bool IsOccupied { get; set; }
        public int FloorId { get; set; }


        public int? VehicleTypeId { get; set; }
    }
}
