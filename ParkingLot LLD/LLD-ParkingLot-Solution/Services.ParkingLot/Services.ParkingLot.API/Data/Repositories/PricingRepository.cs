using Microsoft.EntityFrameworkCore;
using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Data.Repositories
{
    public class PricingRepository : PricingInterface
    {
        private readonly ParkingLotDbContext _context;

        public PricingRepository(ParkingLotDbContext context)
        {
            _context = context;
        }

        public async Task<PricingViewModel> AddPricing(PricingViewModel Pricemodel)
        {
            var price = new Pricing
            {
                Price_per_minute = Pricemodel.Price_per_minute,
                Price_per_hour = Pricemodel.Price_per_hour,
                VehicleTypeId = Pricemodel.VehicleTypeId
            };
            _context.Pricing.Add(price);
            _context.SaveChanges();
            Pricemodel.Id = price.Id;
            return Pricemodel;
        }

        public async Task<PricingViewModel> UpdatePricing(PricingViewModel Pricemodel)
        {
            var price = await _context.Pricing.FindAsync(Pricemodel.Id);
            price.Price_per_minute = Pricemodel.Price_per_minute;
            price.Price_per_hour = Pricemodel.Price_per_hour;
            price.VehicleTypeId = Pricemodel.VehicleTypeId;
            _context.Pricing.Update(price);
            _context.SaveChanges();
            return Pricemodel;
        }

        public async Task<decimal> GetTotalPrice(DateTime entryTime, DateTime exitTime, int vehicleTypeId)
        {
            var pricing = await _context.Pricing
                .Where(s => s.VehicleTypeId == vehicleTypeId)
                .FirstOrDefaultAsync();

            if (pricing == null)
            {
                throw new InvalidOperationException("Pricing not found for the given vehicle type.");
            }

            var duration = exitTime - entryTime;

            var hours = (int)duration.TotalHours;
            var minutes = duration.Minutes;

            var totalPrice = (hours * pricing.Price_per_hour) + (minutes * pricing.Price_per_minute);

            return totalPrice;
        }


    }
}
