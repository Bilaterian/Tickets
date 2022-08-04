using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class ProducerModel
    {
        [Key]
        public int ProducerID { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
