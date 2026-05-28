using CONTROLLERproject;
using DATAproject;
using DATAproject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testsVet.Helpers;

namespace testsVet.Services
{
    public class ServiceCtests
    {
        [Test]
        public async Task GetAllAsync_ReturnsServices()
        {
            var context = TestDbFactory.CreateContext();
            ServiceController controller = new ServiceController(context);
            context.Services.Add(new Service
            {
                Name = "Checkup",
                Price = 50
            });

            await context.SaveChangesAsync();

            var result = await controller.GetAllAsync();

            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task CreateAsync_AddsService()
        {
            var context = TestDbFactory.CreateContext();
            ServiceController controller = new ServiceController(context);
            await controller.CreateAsync(new Service
            {
                Name = "Vaccination",
                Price = 40
            });

            Assert.That(context.Services.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task UpdateAsync_UpdatesService()
        {
            var context = TestDbFactory.CreateContext();
            ServiceController controller = new ServiceController(context);
            var service = new Service
            {
                Name = "Old",
                Price = 10
            };

            context.Services.Add(service);
            await context.SaveChangesAsync();

            service.Name = "New";
            await controller.UpdateAsync(service);

            Assert.That(context.Services.First().Name, Is.EqualTo("New"));
        }

        [Test]
        public async Task DeleteAsync_RemovesService()
        {
            var context = TestDbFactory.CreateContext();
            ServiceController controller = new ServiceController(context);
            var service = new Service
            {
                Name = "Delete",
                Price = 20
            };

            context.Services.Add(service);
            await context.SaveChangesAsync();

            await controller.DeleteAsync(service.Id);

            Assert.That(context.Services.Count(), Is.EqualTo(0));
        }
    }
 }
