using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.ParkingLot.API.Models.Entities
{
    public class Pricing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public decimal Price_per_minute { get; set; } 
        public decimal Price_per_hour { get; set; }

        [Required]
        public int VehicleTypeId { get; set; }

        public VehicleType? VehicleType { get; set; }
    }
}

