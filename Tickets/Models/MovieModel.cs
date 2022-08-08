using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tickets.Data.Enums;

namespace Tickets.Models
{
    public class MovieModel
    {
        [Key]
        public int MovieID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<ActorMovieModel> Actors_Movies { get; set; }

        //Cinema
        public int CinemaID { get; set; }
        [ForeignKey("CinemaID")]
        public CinemaModel Cinema { get; set; }

        //Producer
        public int ProducerID { get; set; }
        [ForeignKey("ProducerID")]
        public ProducerModel Producer { get; set; }
    }
}
