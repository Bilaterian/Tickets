using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorID { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        public string FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        //Relationships
        public List<ActorMovieModel> Actors_Movies { get; set; }

    }
}
