using Services.ParkingLot.API.Data.Repositories;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Services
{
    public class GenerateTicketService
    {
        private readonly GenerateTicketRepository _generateTicketRepository;

        private readonly SlotRepository _slotrepository;

        private readonly PricingRepository _pricerepository;


        public GenerateTicketService(GenerateTicketRepository generateTicketRepository, SlotRepository slotrepository, PricingRepository pricerepository)
        {
            _generateTicketRepository = generateTicketRepository;
            _slotrepository = slotrepository;
            _pricerepository = pricerepository;

        }

        public async Task<GenerateTicketViewModel> GenerateTicket(GenerateTicketViewModel model)
        {
            var result = await _slotrepository.GetAvailableSlotAsync(model.VehicleTypeId);

            if (result != null)
            {
                var (slotId, floorId) = result.Value; 
                model.SlotId = slotId;
                model.FloorId = floorId; 
            }

            var res = await _generateTicketRepository.AddTicket(model);
            return res;
        }

        public async Task<GenerateTicketViewModel?> UpdateExistingTicket(GenerateTicketViewModel model)
        {
            var ticket = await _generateTicketRepository.getTicket(model.Id);
            if (ticket == null)
            {
                return null;
            }

            var price = await _pricerepository.GetTotalPrice(ticket.EntryTime, DateTime.Now, ticket.VehicleTypeId);
            model.totalprice = price;
            model.ExitTime = DateTime.Now;

            var updatedTicket = await _generateTicketRepository.UpdateTicket(model);

            if (ticket.SlotId.HasValue)
            {
                var slotUpdated = await _slotrepository.UpdateSlotAvailability(ticket.SlotId.Value, false);

                if (slotUpdated)
                {
                    return updatedTicket;
                }
            }

            return null;
        }


    }
}


    

