

using Microsoft.AspNetCore.Mvc;
using Services.ParkingLot.API.Data.Repositories;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PriceController
    {
        private readonly PricingRepository _priceRepository;
        public PriceController(PricingRepository priceRepository)
        {
            _priceRepository = priceRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddPrice([FromBody] PricingViewModel model)
        {
            var result = await _priceRepository.AddPricing(model);
            if (result == null)
                return new BadRequestObjectResult("Failed to add price");
            return new OkObjectResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdatePrice([FromBody] PricingViewModel model)
        {
            var result = await _priceRepository.UpdatePricing(model);
            if (result == null)
                return new BadRequestObjectResult("Failed to update price");
            return new OkObjectResult(result);
        }

    }
}
