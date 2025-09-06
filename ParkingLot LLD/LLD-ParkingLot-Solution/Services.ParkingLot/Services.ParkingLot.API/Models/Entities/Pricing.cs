using System.ComponentModel.DataAnnotations;

namespace Services.ParkingLot.API.Models.Entities
{
    public class Pricing
    {
        [Key]
        public int Id { get; set; }
        public decimal Price_per_minute { get; set; } 
        public decimal Price_per_hour { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }

        public VehicleType? VehicleType { get; set; }
    }
}

