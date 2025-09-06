using Microsoft.AspNetCore.Mvc;

using Services.ParkingLot.API.Models.ViewModels;
using Services.ParkingLot.API.Services;

namespace Services.ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FloorController : ControllerBase
    {
        private readonly FloorService _floorService;

        public FloorController(FloorService floorService)
        {
            _floorService = floorService;
        }

        [HttpPost]
        public async Task<IActionResult> AddFloor([FromBody] FloorViewModel model)
        {
            var result = await _floorService.AddFloor(model);

            if (result == null)
                return BadRequest("Failed to add floor");

            return Ok(result);
        }
    }
}
