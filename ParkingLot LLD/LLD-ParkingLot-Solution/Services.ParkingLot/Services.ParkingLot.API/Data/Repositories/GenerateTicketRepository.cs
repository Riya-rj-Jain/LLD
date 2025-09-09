
using Services.ParkingLot.API.Constants.Enums;
using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Data.Repositories
{
    public class GenerateTicketRepository : IGenerateTicketInterface
    {
        private readonly ParkingLotDbContext _context;

        public GenerateTicketRepository(ParkingLotDbContext context)
        {
            _context = context;
        }
        public async Task<GenerateTicketViewModel> AddTicket(GenerateTicketViewModel model)
        {
            var ticket = new Ticket
            {
                VehicleNumber = model.VehicleNumber,
                SlotId = model.SlotId ?? 0,
                EntryTime = DateTime.Now,
                Status = TicketStatus.Active, 
                VehicleTypeId = model.VehicleTypeId
            };
            _context.Ticket.Add(ticket);
            await _context.SaveChangesAsync();
            return model;
        }

        public async Task<GenerateTicketViewModel> UpdateTicket(GenerateTicketViewModel model)
        {
            var ticket = await _context.Ticket.FindAsync(model.Id);

            if (ticket == null)
            {
                return null;
            }

            ticket.VehicleNumber = model.VehicleNumber;
            ticket.ExitTime = model.ExitTime;
            ticket.Status = TicketStatus.Closed ; 
            ticket.VehicleTypeId = model.VehicleTypeId;
            ticket.totalprice = model.totalprice;

            _context.Ticket.Update(ticket);
            await _context.SaveChangesAsync();

            return model;
        }

        public async Task<GenerateTicketViewModel> getTicket(int TicketId)
        {
            var ticket = await _context.Ticket.FindAsync(TicketId);

            if (ticket == null)
            {
                return null;
            }

            return new GenerateTicketViewModel
            {
                Id = ticket.Id,
                VehicleNumber = ticket.VehicleNumber,
                SlotId = ticket.SlotId,
                VehicleTypeId = ticket.VehicleTypeId,
                totalprice = ticket.totalprice,
                EntryTime =ticket.EntryTime,

            };
        }
    }
}
