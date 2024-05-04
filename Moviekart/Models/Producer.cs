using System.ComponentModel.DataAnnotations;

namespace Moviekart.Models
{
    public class Producer
    {
        [Key]
        public int ActorID { get; set; }

        public string FullName { get; set; }

        public string ProfilePictureURL { get; set; }

        public string Bio { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
