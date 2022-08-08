
using Microsoft.EntityFrameworkCore;
using Tickets.Models;

namespace Tickets.Data
{
    public class TicketsDbContext: DbContext
    {
        public TicketsDbContext(DbContextOptions<TicketsDbContext> options) :base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorMovieModel>().HasKey(am => new
            {
                am.ActorID,
                am.MovieID
            });

            modelBuilder.Entity<ActorMovieModel>().HasOne( m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey( m => m.MovieID);
            modelBuilder.Entity<ActorMovieModel>().HasOne( a => a.Actor).WithMany(am => am.Actors_Movies).HasForeignKey( a => a.ActorID);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<ActorMovieModel> Actors_Movies { get; set; }
        public DbSet<CinemaModel> Cinemas { get; set; }
        public DbSet<ProducerModel> Producers { get; set; }
    }
}
