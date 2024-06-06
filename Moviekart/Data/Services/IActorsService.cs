using Moviekart.Models;

namespace Moviekart.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllActors();
        Actor GetActorByName(string name);
        Task<Actor> GetActorById(int id);
        void Add(Actor actor);
        Actor update(int id, Actor NewActor);
        void delete(int id);

    }
}
