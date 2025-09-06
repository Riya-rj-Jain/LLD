using Services.ParkingLot.API.Models.Entities;

namespace Services.ParkingLot.API.Interfaces
{
    public interface PricingInterface
    {
        Task AddPricing(Pricing Pricemodel);
        Task UpdatePricing(Pricing Pricemodel);

    }
}
