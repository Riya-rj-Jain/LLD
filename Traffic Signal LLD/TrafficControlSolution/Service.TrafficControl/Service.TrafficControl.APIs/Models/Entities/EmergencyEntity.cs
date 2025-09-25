

using NuGet.Packaging.Signing;
using Service.TrafficControl.APIs.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.TrafficControl.APIs.Models.Entities
{
    public class EmergencyEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int EmergencyRequestId { get; set; }

        public int IntersectionId { get; set; }

        public InterSection? intersection { get; set; }

        public DirectionEnum Direction { get; set; }

        public int Duration { get; set;}

        public bool IsActive { get; set; }

        public Timestamp RequestedAt { get; set; }

        public Timestamp? EndedAt { get; set; }


    }
}
