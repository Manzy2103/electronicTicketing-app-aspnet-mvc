using eTickets.Data;
using eTickets.Helpers.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Services
{
    public class ProducerService : IProducerService
    {
        private readonly TicketDbContext _context;

        public ProducerService(TicketDbContext context)
        {
            _context = context;
        }

        public async Task<OutputResponse> GetAllAsync()
        {
            var producers = await _context.Producers.ToListAsync();
            return new OutputResponse
            {
                IsErrorOccurred = false,
                Result = producers
            };
        }
    }
}
