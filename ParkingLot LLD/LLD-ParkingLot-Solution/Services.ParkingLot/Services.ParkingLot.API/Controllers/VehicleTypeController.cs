

using Microsoft.AspNetCore.Mvc;
using Services.ParkingLot.API.Data.Repositories;

namespace Services.ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VehicleTypeController
    {
        private readonly VehicleTypeRepository _vehicleTypeRepository;

        public VehicleTypeController(VehicleTypeRepository vehicleTypeRepository)
        {
            _vehicleTypeRepository = vehicleTypeRepository;
        }


        [HttpPost]
        public async Task<IActionResult> AddVehicleType([FromBody] string vehicleType)
        {
            await _vehicleTypeRepository.AddVehicleType(vehicleType);
            return new OkResult();
        }

        [HttpPut("{vehicleTypeId}")]    
        public async Task<IActionResult> UpdateVehicleType(int vehicleTypeId, [FromBody] string vehicleType)
        {
            await _vehicleTypeRepository.UpdateVehicleType(vehicleTypeId, vehicleType);
            return new OkResult();
        }

        [HttpDelete("{vehicleTypeId}")] 
        public async Task<IActionResult> DeleteVehicleType(int vehicleTypeId)
        {
            var result = await _vehicleTypeRepository.DeleteVehicleType(vehicleTypeId);
            if (!result)
                return new BadRequestObjectResult("Failed to delete vehicle type");
            return new OkObjectResult("Vehicle type deleted successfully");
        }


    }
}
