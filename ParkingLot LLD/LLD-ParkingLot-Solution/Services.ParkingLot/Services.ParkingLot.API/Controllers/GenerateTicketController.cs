using Microsoft.AspNetCore.Mvc;
using Services.ParkingLot.API.Models.ViewModels;
using Services.ParkingLot.API.Services;


namespace Services.ParkingLot.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenerateTicketController : ControllerBase
    {
        private readonly GenerateTicketService _generateservice;

        public GenerateTicketController(GenerateTicketService generateservice)
        {
            _generateservice = generateservice;
        }

        [HttpPost]
        public async Task<ActionResult<GenerateTicketViewModel>> AddNewTicket([FromBody] GenerateTicketViewModel model)
        {
            var res = await _generateservice.GenerateTicket(model);
            return Ok(res);
        }

        [HttpPut]
        public async Task<ActionResult<GenerateTicketViewModel>> UpdateTicket([FromBody] GenerateTicketViewModel model)
        {
            var res = await _generateservice.UpdateExistingTicket(model);
            return Ok(res);
        }

    }

}
