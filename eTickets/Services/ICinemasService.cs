using eTickets.Helpers.Models;

namespace eTickets.Services
{
    public interface ICinemasService
    {
        Task<OutputResponse> GetAllAsync();
    }
}