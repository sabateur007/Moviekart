using Moviekart.Data;
using Moviekart.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moviekart.Models
{
    public class Movie : IEntityBase
    {
        public int Id { get; set; }
        [Display(Name ="Title")]
        public string Title { get; set; }
        [Display(Name = "Discription")]
        public string Description { get; set; }
        [Display(Name = "Price")]
        public double Price { get; set; }
        [Display(Name = "IMage")]

        public string ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [Display(Name = "genre")]

        public MovieCategory Category { get; set; }

        //relationships
        public List<Actor_Movie> Actor_Movies { get; set; }

        //cinema
        [ForeignKey("CinemaId")]
        public int CinemaId { get; set; }
       
        public Cinema Cinema { get; set; }

        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }
    }
}
