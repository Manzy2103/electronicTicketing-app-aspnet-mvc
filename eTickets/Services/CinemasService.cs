using eTickets.Data;
using eTickets.Helpers.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services
{
    public class CinemasService : ICinemasService
    {
        private readonly TicketDbContext _context;

        public CinemasService(TicketDbContext context)
        {
            _context = context;
        }

        public async Task<OutputResponse> GetAllAsync()
        {
            var cinemas = await _context.Cinemas.ToListAsync();
            return new OutputResponse
            {
                IsErrorOccurred = false,
                Result = cinemas
            };
        }
    }
}
