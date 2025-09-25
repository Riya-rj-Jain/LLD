using Service.TrafficControl.APIs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.TrafficControl.APIs.Models.Entities
{
    public class SignalTimingEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SignalTimingId { get; set; }

        public int IntersectionId { get; set; }

        public InterSection? intersection { get; set; }

        public DirectionEnum Direction { get; set; }

        public  bool isDynamic { get; set; }

        public int GreenDuration { get; set; }

        public int YellowDuration { get; set; }

        public int RedDuration { get; set; }

    }
}
