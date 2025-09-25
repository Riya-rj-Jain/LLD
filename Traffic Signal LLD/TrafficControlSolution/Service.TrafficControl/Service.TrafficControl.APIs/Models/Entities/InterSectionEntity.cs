using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.TrafficControl.APIs.Models.Entities
{
    public class InterSection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IntersectionId { get; set; }

        public bool IsCyclePaused { get; set; }

        public bool EmergencyFlag { get; set; }
    }
}
