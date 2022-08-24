using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class CinemaModel
    {
        [Key]
        public int CinemaID { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relationships
        public List<MovieModel> Movies { get; set; }

    }
}
