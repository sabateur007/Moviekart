using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
            _context.Actors.Add(actor);
            _context.SaveChanges();
        }



        public async Task<Actor> GetActorById(int id)
        {
            var result = await _context.Actors.FirstOrDefaultAsync(n => n.ActorID == id);
            return result;
        }


        public async Task<IEnumerable<Actor>> GetAllActors()
        {
            var result = await _context.Actors.ToListAsync();
            return result;

        }

        public async Task<Actor> Update(int id, Actor NewActor)
        {
            NewActor.ActorID = id;
            _context.Update(NewActor);
            await _context.SaveChangesAsync();
            return NewActor;
        }

        public async Task Delete(int id)
        {
            var result = await GetActorById(id);
            _context.Remove(result);
            await _context.SaveChangesAsync();
        }
    }
}
