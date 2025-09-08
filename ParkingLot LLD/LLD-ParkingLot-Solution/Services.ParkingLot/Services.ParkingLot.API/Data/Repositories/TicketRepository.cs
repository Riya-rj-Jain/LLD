using Services.ParkingLot.API.Interfaces;
using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Data.Repositories
{
    public class TicketRepository : TicketInterface
    {
        private readonly ParkingLotDbContext _context;

        public TicketRepository(ParkingLotDbContext context)
        {
            _context = context;
        }
        public async Task<TicketViewModel> AddTicket(TicketViewModel ticket)    
        {
            var entity = new Ticket
            {
                VehicleNumber = ticket.VehicleNumber,
                SlotId = ticket.SlotId,
                totalprice = ticket.TotalPrice,
                EntryTime = ticket.EntryTime,
                ExitTime = ticket.ExitTime
            };

            _context.Ticket.Add(entity);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task<bool> DeleteTicket(int TicketId)
        {
            var ticket = await _context.Ticket.FindAsync(TicketId);
            if (ticket == null)
            {
                return false;
            }

            _context.Ticket.Remove(ticket);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<TicketViewModel> UpdateTicket(TicketViewModel ticket)
        {
            var entity = await _context.Ticket.FindAsync(ticket.TicketId);
            if (entity == null)
            {
                return null;
            }

            entity.VehicleNumber = ticket.VehicleNumber;
            entity.SlotId = ticket.SlotId;
            entity.totalprice = ticket.TotalPrice;
            entity.EntryTime = ticket.EntryTime;
            entity.ExitTime = ticket.ExitTime;

            await _context.SaveChangesAsync();

            return ticket;
        }
    }
}
