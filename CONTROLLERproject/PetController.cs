using DATAproject;
using DATAproject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTROLLERproject
{
    public class PetController
    {
        private readonly VetContext context ;
        public PetController()
        {
            context = new VetContext();
        }
        public PetController(VetContext c)
        {
            context = c;
        }
        public async Task<List<Pet>> GetAllAsync()
        {
            return await context.Pets
                .Include(x => x.Breed)
                .ThenInclude(x => x.Animal)
                .Include(x => x.Owner).Include(x=>x.Breed)
                .ToListAsync();
        }

        

        public async Task CreateAsync(Pet pet)
        {
            await context.Pets.AddAsync(pet);

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Pet pet)
        {
            var res = context.Pets.Find(pet.Id);
            res.Name = pet.Name;
            res.Age = pet.Age;
            res.BreedId = pet.BreedId;
            res.OwnerId = pet.OwnerId;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pet = await context.Pets.FindAsync(id);

            if (pet != null)
            {
                context.Pets.Remove(pet);

                await context.SaveChangesAsync();
            }
        }
        public async Task<Pet> GetById(int id)
        {
            var user = await context.Pets.FindAsync(id);
            return user;
        }
    }
}
