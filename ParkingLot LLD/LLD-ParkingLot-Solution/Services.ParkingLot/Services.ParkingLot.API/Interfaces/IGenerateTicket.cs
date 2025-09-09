
using Services.ParkingLot.API.Models.ViewModels;

namespace Services.ParkingLot.API.Interfaces
{
    public interface IGenerateTicketInterface
    {
        Task<GenerateTicketViewModel> AddTicket(GenerateTicketViewModel model);

        Task<GenerateTicketViewModel> UpdateTicket(GenerateTicketViewModel model);

        Task<GenerateTicketViewModel> getTicket(int TicketId);
    }
}
