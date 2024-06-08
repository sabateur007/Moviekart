using Moviekart.Models;

namespace Moviekart.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
       
        Task<Actor> GetActorById(int id);
        void Add(Actor actor);
        Task<Actor> Update(int id, Actor NewActor);
        Task Delete(int id);

    }
}
