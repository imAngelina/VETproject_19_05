using DATAproject;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testsVet.Helpers
{
    public class TestDbFactory
    {
        public static VetContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<VetContext>().UseInMemoryDatabase(Guid.NewGuid().ToString()).Options;
            VetContext context = new VetContext(options);
            context.Database.EnsureCreated();
            return context;
        }
    }
}
