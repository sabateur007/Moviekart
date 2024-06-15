using Moviekart.Data.Base;
using Moviekart.Models;

namespace Moviekart.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        public Task<Movie> GetMovieByIdAsync(int id);

    }
}
