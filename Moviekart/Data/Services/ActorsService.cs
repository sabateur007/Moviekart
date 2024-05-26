using Microsoft.EntityFrameworkCore;
using Moviekart.Models;
using System.Collections.Generic;

namespace Moviekart.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context) 
        { 
            _context = context;
        }
        public void Add(Actor actor)
        {
            throw new NotImplementedException();
        }

        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorById(int id)
        {
            throw new NotImplementedException();
        }

        public Actor GetActorByName(string name)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> GetAllActors()
        {
           var result = await _context.Actors.ToListAsync();
            return result;

        }

        public Actor update(int id, Actor NewActor)
        {
            throw new NotImplementedException();
        }
    }
}
