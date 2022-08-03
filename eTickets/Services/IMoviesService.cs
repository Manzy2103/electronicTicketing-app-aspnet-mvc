using eTickets.Helpers.Models;

namespace eTickets.Services
{
    public interface IMoviesService
    {
        Task<OutputResponse> GetAllAsync();
    }
}