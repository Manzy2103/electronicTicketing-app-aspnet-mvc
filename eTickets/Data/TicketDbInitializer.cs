using eTickets.Helpers.enums;
using eTickets.Models;

namespace eTickets.Data
{
    public class TicketDbInitializer
    {
        public static async Task SeedAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var ServiceProvider = serviceScope.ServiceProvider;
                var context = ServiceProvider.GetService<TicketDbContext>();
                var logger = ServiceProvider.GetRequiredService<ILogger<TicketDbContext>>();
                await context.Database.EnsureCreatedAsync();
                var isFound = false;
                try
                {
                    logger.LogInformation($"Seeding to database associated with context {context.Database.ProviderName}");

                    //Cinemas
                    if (!context.Cinemas.Any())
                    {
                        isFound = true;
                        context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                        await context.SaveChangesAsync();
                    }

                    //Actors
                    if (!context.Actors.Any())
                    {
                        isFound = true;
                        context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                        await context.SaveChangesAsync();
                    }

                    //Producers
                    if (!context.Producers.Any())
                    {
                        isFound = true;
                        context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                        await context.SaveChangesAsync();
                    }

                    //Movies
                    if (!context.Movies.Any())
                    {
                        isFound = true;
                        var cinemasIds = context.Cinemas.Select(x => x.CinemaId).ToList();
                        var producersIds = context.Producers.Select(x => x.ProducerId).ToList();
                        context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = cinemasIds[1],
                            ProducerId = producersIds[1],
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = cinemasIds[2],
                            ProducerId = producersIds[2],
                            movieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = cinemasIds[3],
                            ProducerId = producersIds[3],
                            movieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaId = cinemasIds[4],
                            ProducerId = producersIds[4],
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaId = cinemasIds[3],
                            ProducerId = producersIds[3],
                            movieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaId = cinemasIds[0],
                            ProducerId = producersIds[0],
                            movieCategory = MovieCategory.Drama
                        }
                    });
                        await context.SaveChangesAsync();
                    }

                    //Actors & Movies
                    if (!context.Actor_Movies.Any())
                    {
                        isFound = true;
                        var rand = new Random();
                        var actorsIds = context.Actors.Select(x => x.ActorId).ToArray();
                        var moviesIds = context.Movies.Select(x => x.MovieId).ToArray();
                        for (int i = 0; i < 10; i++)
                        {
                            var actorMovie = new Actor_Movie()
                            {
                                ActorId = actorsIds[rand.Next(actorsIds.Length)],
                                MovieId = moviesIds[rand.Next(moviesIds.Length)]
                            };
                            var alreadyExists = context.Actor_Movies.Any(x => x.MovieId.Equals(actorMovie.MovieId)
                            && x.ActorId.Equals(actorMovie.ActorId));
                            if (!alreadyExists)
                            {
                                context.Actor_Movies.Add(actorMovie);
                                await context.SaveChangesAsync();
                            }
                        }
                    }

                    if (isFound)
                    {
                        logger.LogInformation($"Seeding to database associated with context {context.Database.ProviderName} Completed successfully");
                    }
                    else
                    {
                        logger.LogInformation("All data is available in the database nothing to seed");
                    }
                }
                catch (Exception ex)
                {
                    logger.LogInformation($"Filed to seed to the database Message: {ex.Message}");
                    logger.LogInformation($"Filed to seed to the database StackTrace: {ex.StackTrace}");
                }
            }
        }
    }
}