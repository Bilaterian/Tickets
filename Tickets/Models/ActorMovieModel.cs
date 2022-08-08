namespace Tickets.Models
{
    public class ActorMovieModel
    {
        public int MovieID { get; set; }
        public MovieModel Movie {get; set; }
        public int ActorID { get; set; }
        public ActorModel Actor { get; set; }

        
    }
}
