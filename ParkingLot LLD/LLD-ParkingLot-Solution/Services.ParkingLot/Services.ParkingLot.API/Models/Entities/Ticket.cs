using Services.ParkingLot.API.Constants.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Services.ParkingLot.API.Models.Entities
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string VehicleNumber { get; set; }

        public int SlotId { get; set; }

        public Slot? Slot { get; set; }

        public decimal totalprice { get; set; }

        public DateTime ExitTime { get; set; }

        public DateTime EntryTime { get; set; }

        [Required]
        public TicketStatus Status { get; set; }

        public int VehicleTypeId { get; set; }
        public VehicleType? VehicleType { get; set; }




    }
}
