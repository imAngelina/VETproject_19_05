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
    public class ServiceController
    {
        private readonly VetContext context;

        public ServiceController()
        {
            context = new VetContext();
        }
        public ServiceController(VetContext c)
        {
            context = c;
        }

        public async Task<List<Service>> GetAllAsync()
        {
            return await context.Services.ToListAsync();
        }


        public async Task CreateAsync(Service service)
        {
            await context.Services.AddAsync(service);

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Service service)
        {
            var res = context.Services.Find(service.Id);
            res.Name = service.Name;
            res.Price = service.Price;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var service = await context.Services.FindAsync(id);

            if (service != null)
            {
                context.Services.Remove(service);

                await context.SaveChangesAsync();
            }
        }
        public async Task<Service> GetById(int id)
        {
            var user = await context.Services.FindAsync(id);
            return user;
        }
    }
}
