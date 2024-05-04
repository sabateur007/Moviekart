using System.ComponentModel.DataAnnotations;

namespace Moviekart.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }

        [Display(Name ="Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "Bio")]
        public string Bio { get; set;}

        //relationships

        public List<Actor_Movie> Actor_Movies { get; set; }
    }
}
