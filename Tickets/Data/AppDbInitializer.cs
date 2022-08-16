using Tickets.Data.Enums;
using Tickets.Models;

namespace Tickets.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<CinemaModel>()
                    {
                        new CinemaModel()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new CinemaModel()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<ActorModel>()
                    {
                        new ActorModel()
                        {
                            FullName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new ActorModel()
                        {
                            FullName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new ActorModel()
                        {
                            FullName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<ProducerModel>()
                    {
                        new ProducerModel()
                        {
                            FullName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new ProducerModel()
                        {
                            FullName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new ProducerModel()
                        {
                            FullName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new ProducerModel()
                        {
                            FullName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new ProducerModel()
                        {
                            FullName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            ProfilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<MovieModel>()
                    {
                        new MovieModel()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaID = 3,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new MovieModel()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaID = 1,
                            ProducerID = 1,
                            MovieCategory = MovieCategory.Action
                        },
                        new MovieModel()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaID = 4,
                            ProducerID = 4,
                            MovieCategory = MovieCategory.Horror
                        },
                        new MovieModel()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                            CinemaID = 1,
                            ProducerID = 2,
                            MovieCategory = MovieCategory.Documentary
                        },
                        new MovieModel()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                            CinemaID = 1,
                            ProducerID = 3,
                            MovieCategory = MovieCategory.Cartoon
                        },
                        new MovieModel()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            StartDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                            CinemaID = 1,
                            ProducerID = 5,
                            MovieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors_Movies
                if (!context.Actors_Movies.Any())
                {
                    context.Actors_Movies.AddRange(new List<ActorMovieModel>()
                    {
                        new ActorMovieModel()
                        {
                            ActorID = 1,
                            MovieID = 1
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 3,
                            MovieID = 1
                        },

                         new ActorMovieModel()
                        {
                            ActorID = 1,
                            MovieID = 2
                        },
                         new ActorMovieModel()
                        {
                            ActorID = 4,
                            MovieID = 2
                        },

                        new ActorMovieModel()
                        {
                            ActorID = 1,
                            MovieID = 3
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 2,
                            MovieID = 3
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 5,
                            MovieID = 3
                        },


                        new ActorMovieModel()
                        {
                            ActorID = 2,
                            MovieID = 4
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 3,
                            MovieID = 4
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 4,
                            MovieID = 4
                        },


                        new ActorMovieModel()
                        {
                            ActorID = 2,
                            MovieID = 5
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 3,
                            MovieID = 5
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 4,
                            MovieID = 5
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 5,
                            MovieID = 5
                        },


                        new ActorMovieModel()
                        {
                            ActorID = 3,
                            MovieID = 6
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 4,
                            MovieID = 6
                        },
                        new ActorMovieModel()
                        {
                            ActorID = 5,
                            MovieID = 6
                        },
                    });
                    context.SaveChanges();
                }

            }
        }
    }
}
