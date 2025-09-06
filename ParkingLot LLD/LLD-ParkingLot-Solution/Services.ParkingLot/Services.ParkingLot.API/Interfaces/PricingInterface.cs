
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Interfaces
{
    public interface PricingInterface
    {
        Task<PricingViewModel> AddPricing(PricingViewModel Pricemodel);
        Task<PricingViewModel> UpdatePricing(PricingViewModel Pricemodel);

    }
}
