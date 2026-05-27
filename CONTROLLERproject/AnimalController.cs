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
    public class AnimalController
    {
        private readonly VetContext context;

        public AnimalController()
        {
            context = new VetContext();
        }
        public AnimalController(VetContext c)
        {
            context = c;
        }
        public async Task<List<Animal>> GetAllAsync()
        {
            return await context.Animals
                .Include(x => x.Breeds)
                .ToListAsync();
        }


        public async Task CreateAsync(Animal animal)
        {
            await context.Animals.AddAsync(animal);

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Animal animal)
        {
            var res = context.Animals.Find(animal.Id);
            res.Type = animal.Type;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var animal = await context.Animals.FindAsync(id);

            if (animal != null)
            {
                context.Animals.Remove(animal);

                await context.SaveChangesAsync();
            }
        }
    }
}
