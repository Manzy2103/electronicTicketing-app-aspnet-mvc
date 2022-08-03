using eTickets.Data;
using eTickets.Helpers.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly TicketDbContext _context;

        public MoviesService(TicketDbContext context)
        {
            _context = context;
        }

        public async Task<OutputResponse> GetAllAsync()
        {
            var movies = await _context.Movies
                .Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();
            return new OutputResponse
            {
                IsErrorOccurred = false,
                Result = movies
            };
        }
    }
}
