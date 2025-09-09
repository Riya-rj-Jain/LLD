using Services.ParkingLot.API.Constants.Enums;
using System.ComponentModel.DataAnnotations;


namespace Services.ParkingLot.API.Models.ViewModels
{
    public class GenerateTicketViewModel
    {
        public int Id { get; set; }
        public string VehicleNumber { get; set; }

        public int? SlotId { get; set; }

        public int? FloorId { get; set; }


        public decimal? totalprice { get; set; }

        public DateTime? ExitTime { get; set; }

        public DateTime EntryTime { get; set; }

        public TicketStatus Status { get; set; }

        public int VehicleTypeId { get; set; }

    }
}
