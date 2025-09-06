
using System.ComponentModel.DataAnnotations;

namespace Services.ParkingLot.API.Models.ViewModels
{
    public class TicketViewModel
    {
        public int TicketId { get; set; }

        [Required]
        public string VehicleNumber { get; set; }
        public int SlotId { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime ExitTime { get; set; }
        public DateTime EntryTime { get; set; }

    }
}
