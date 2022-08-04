using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class ActorModel
    {
        [Key]
        public int ActorID { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
