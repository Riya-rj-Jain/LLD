

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Service.TrafficControl.APIs.Models.Entities
{
    public class IntersectionConfigurationEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int IntersectionId { get; set; }

        public InterSection? intersection { get; set; }

        public int CurrentPhase { get; set; }

        public bool IsPaused { get; set; }

        public int PausedAtPhase { get; set; }

        public long PhaseStartTime { get; set; }

    }
}
