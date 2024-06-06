using System.ComponentModel.DataAnnotations;

namespace Moviekart.Models
{
    public class Actor
    {
        [Key]
        public int ActorID { get; set; }



        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="give the full name , empty name not allowed")]
        public string FullName { get; set; }



        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage = "give the pic url")]
        public string ProfilePictureURL { get; set; }



        [Display(Name = "Biography")]
        [Required(ErrorMessage = "give the bio ")]
        public string Bio { get; set;}

        //relationships

        public List<Actor_Movie>? Actor_Movies { get; set; }
    }
}
