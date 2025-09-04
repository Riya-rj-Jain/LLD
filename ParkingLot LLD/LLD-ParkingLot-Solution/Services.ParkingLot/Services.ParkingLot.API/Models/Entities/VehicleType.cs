

using System.ComponentModel.DataAnnotations;

namespace Services.ParkingLot.API.Models.Entities
{
    public class VehicleType
    {
        [Key]
        public int VehicleTypeId { get; set; }
        public string VehicleName { get; set; }

    }
}
