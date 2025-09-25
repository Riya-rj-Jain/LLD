using Service.TrafficControl.APIs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.TrafficControl.APIs.Models.Entities
{
    public class TrafficLightEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  int TrafficLightId { get; set; }

        public int IntersectionId { get; set; }

        public InterSection? intersection { get; set; }

        public DirectionEnum Direction { get; set; }

        public CurrentStateEnum currentState { get; set; }


    }
}
