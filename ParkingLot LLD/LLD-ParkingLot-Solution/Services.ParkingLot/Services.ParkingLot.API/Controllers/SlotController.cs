

using Microsoft.AspNetCore.Mvc;
using Services.ParkingLot.API.Data.Repositories;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SlotController
    {
        private readonly SlotRepository _slotRepository;
        public SlotController(SlotRepository slotRepository)
        {
            _slotRepository = slotRepository;
        }

        [HttpPost]
        public async Task<IActionResult> AddSlot([FromBody] SlotViewModel model)
        {
            var result = await _slotRepository.AddSlot(model);
            if (result == null)
                return new BadRequestObjectResult("Failed to add slot");
            return new OkObjectResult(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSlot([FromBody] SlotViewModel model)
        {
            var result = await _slotRepository.UpdateSloot(model);
            if (result == null)
                return new BadRequestObjectResult("Failed to update slot");
            return new OkObjectResult(result);
        }

        [HttpDelete("{slotId}")]
        public async Task<IActionResult> DeleteSlot(int slotId)
        {
            var result = await _slotRepository.DeleteSlot(slotId);
            if (!result)
                return new BadRequestObjectResult("Failed to delete slot");
            return new OkObjectResult("Slot deleted successfully");
        }

    }
}