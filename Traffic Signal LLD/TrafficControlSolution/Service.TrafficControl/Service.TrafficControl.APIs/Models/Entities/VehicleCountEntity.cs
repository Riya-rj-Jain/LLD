using Service.TrafficControl.APIs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
;

namespace Service.TrafficControl.APIs.Models.Entities
{
    public class VehicleCountEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int VehicleCountId { get; set; }

        public int IntersectionId { get; set; }

        public InterSection? intersection { get; set; }

        public DirectionEnum Direction { get; set; }

        public int VehicleCount { get; set; }

    }
}
