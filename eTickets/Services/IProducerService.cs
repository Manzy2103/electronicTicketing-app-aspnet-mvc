using eTickets.Helpers.Models;

namespace eTickets.Services
{
    public interface IProducerService
    {
        Task<OutputResponse> GetAllAsync();
    }
}