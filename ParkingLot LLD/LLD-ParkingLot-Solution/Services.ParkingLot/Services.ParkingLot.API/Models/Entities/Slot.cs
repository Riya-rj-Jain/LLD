

using System.ComponentModel.DataAnnotations;

namespace Services.ParkingLot.API.Models.Entities
{
    public class Slot
    {
        [Key]
        public int SlotId { get; set; }

        public string? SlotName { get; set; }

        [Required]
        public bool IsOccupied { get; set; }
        public int FloorId { get; set; }

        public Floor? Floor { get; set; }

        public int VehicleTypeId { get; set; }

        public VehicleType? VehicleType { get; set; }
    }
}
