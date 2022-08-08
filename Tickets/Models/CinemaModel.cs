using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class CinemaModel
    {
        [Key]
        public int CinemaID { get; set; }
        public string Logo { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        //Relationships
        public List<MovieModel> Movies { get; set; }

    }
}
