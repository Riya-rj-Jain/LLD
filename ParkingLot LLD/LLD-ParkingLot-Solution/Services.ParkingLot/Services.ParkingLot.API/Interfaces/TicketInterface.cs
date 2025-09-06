

using Services.ParkingLot.API.Models.Entities;
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Interfaces
{
    public interface TicketInterface
    {
        Task<TicketViewModel> AddTicket(TicketViewModel ticket);
        Task<TicketViewModel> UpdateTicket(TicketViewModel ticket);
        Task<bool> DeleteTicket(int TicketId);
    }
}
