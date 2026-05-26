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
    public class BreedController
    {
        private readonly VetContext context = new VetContext();


        public async Task<List<Breed>> GetAllAsync()
        {
            return await context.Breeds
                .Include(x => x.Animal)
                .ToListAsync();
        }

      
        public async Task CreateAsync(Breed breed)
        {
            await context.Breeds.AddAsync(breed);

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Breed breed)
        {
            var res = context.Breeds.Find(breed.Id);
            res.Name = breed.Name;
            res.AnimalId = breed.AnimalId;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var breed = await context.Breeds.FindAsync(id);

            if (breed != null)
            {
                context.Breeds.Remove(breed);

                await context.SaveChangesAsync();
            }
        }
    }
}
