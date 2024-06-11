using Moviekart.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace Moviekart.Models
{
    public class Cinema :IEntityBase
    {
        public int Id { get; set; }
        [Display(Name = "Cinema Logo")]
        public string Logo { get; set; }
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }
    }
}
