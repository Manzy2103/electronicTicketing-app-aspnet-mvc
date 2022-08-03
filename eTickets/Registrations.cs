using eTickets.Services;

namespace eTickets
{
    public static class Registrations
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddScoped<IProducerService, ProducerService>();
            services.AddScoped<IMoviesService, MoviesService>();
            services.AddScoped<ICinemasService, CinemasService>();
            return services.AddScoped<IActorsService, ActorsService>();
        }
    }
}