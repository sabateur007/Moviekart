using Moviekart.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Moviekart.Data.ViewModels
{
    public class NewMovieVM
    {
        
        [Display(Name = "Movie name")]
        [Required(ErrorMessage ="movie name cannot be empty")]
        public string Title { get; set; }

        [Display(Name = "Discription")]
        public string Description { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please enter the price")]
        public double Price { get; set; }

        [Display(Name = "ImageURL")]
        [Required(ErrorMessage = "Image URL is required")]
        public string ImageURL { get; set; }

        [Display(Name = "start date")]
        [Required(ErrorMessage = "please enter start date ")]
        public DateTime StartDate { get; set; }

        [Display(Name = "end date")]
        [Required(ErrorMessage = "please enter end date ")]
        public DateTime EndDate { get; set; }


        [Display(Name = "genre")]
        [Required(ErrorMessage = "enter genre type")]
        public MovieCategory Category { get; set; }

        //relationships
        [Display(Name = "actor/actors of the movie")]
        [Required(ErrorMessage = "give actor name/names")]
        public List<int> ActorIDs { get; set; }

        //cinema
        [Display(Name = "cinema")]
        [Required(ErrorMessage = "give cinema name")]
        public int CinemaId { get; set; }

        //producer
        [Display(Name = "producer")]
        [Required(ErrorMessage = "give producer name")]
        public int ProducerId { get; set; }
        

    }
}
