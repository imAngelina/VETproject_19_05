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
    public class UserController
    {
        private readonly VetContext context;

        public UserController()
        {
            context = new VetContext();
        }
        public UserController(VetContext c)
        {
            context = c;
        }

        public async Task<List<Userr>> GetAllAsync()
        {
            return await context.Users
                .Include(x => x.EmployeeType)
                .ToListAsync();
        }

      

        public async Task<Userr?> LoginAsync( string username, string password)
        {
            return await context.Users
                .FirstOrDefaultAsync(x =>
                    x.Username == username &&
                    x.Password == password);
        }

        public async Task CreateAsync(Userr user)
        {
            await context.Users.AddAsync(user);

            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Userr user)
        {
            var res = context.Users.Find(user.Id);
            res.Username = user.Username;
            res.Password = user.Password;
            res.FullName = user.FullName;
            res.Role = user.Role;

            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var user = await context.Users.FindAsync(id);

            if (user != null)
            {
               context.Users.Remove(user);

                await context.SaveChangesAsync();
            }
        }
        public async Task<Userr> GetById(int id)
        {
            var user = await context.Users.FindAsync(id);
            return user;
        }
    }
}
