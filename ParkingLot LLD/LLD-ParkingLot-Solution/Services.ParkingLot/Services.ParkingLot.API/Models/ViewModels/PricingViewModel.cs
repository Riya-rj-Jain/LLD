

namespace Services.ParkingLot.API.Models.ViewModels
{
    public class PricingViewModel
    {
        public int Id { get; set; }
        public decimal Price_per_minute { get; set; }
        public decimal Price_per_hour { get; set; }

        public int VehicleTypeId { get; set; }
    }
}
