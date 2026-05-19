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
        private readonly VetContext context = new VetContext();

        public async Task<List<Pet>> GetAllAsync()
        {
            return await context.Pets
                .Include(x => x.Breed)
                .ThenInclude(x => x.Animal)
                .Include(x => x.Owner).Include(x=>x.Breed)
                .ToListAsync();
        }

        public async Task<List<Pet>> GetByOwnerAsync(int ownerId)
        {
            return await context.Pets
                .Include(x => x.Breed)
                .Where(x => x.OwnerId == ownerId)
                .ToListAsync();
        }

        public async Task<Pet?> GetByIdAsync(int id)
        {
            return await context.Pets
                .Include(x => x.Breed)
                .Include(x => x.Owner)
                .FirstOrDefaultAsync(x => x.Id == id);
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
    }
}
