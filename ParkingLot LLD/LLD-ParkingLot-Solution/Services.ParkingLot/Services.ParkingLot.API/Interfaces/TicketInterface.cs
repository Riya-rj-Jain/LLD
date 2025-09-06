

using Services.ParkingLot.API.Models.Entities;

namespace Services.ParkingLot.API.Interfaces
{
    public interface TicketInterface
    {
        Task AddTicket(Ticket ticket);
        Task UpdateTicket(Ticket ticket);
        Task<bool> DeleteTicket(int TicketId);
    }
}
