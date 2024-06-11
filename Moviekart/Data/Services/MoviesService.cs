using Moviekart.Data.Base;
using Moviekart.Models;

namespace Moviekart.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(AppDbContext _context) : base(_context) 
        {
            
        }
    }
}
