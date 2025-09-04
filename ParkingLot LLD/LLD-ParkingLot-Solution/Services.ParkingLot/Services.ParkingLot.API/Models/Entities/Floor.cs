using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Services.ParkingLot.API.Models.Entities
{
    public class Floor
    {
        [Key] 
        public int FloorId { get; set; }

        public int Floor_number { get; set; }

        public int numberOfSlots { get; set; }
    }
}
