using CONTROLLERproject;
using DATAproject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testsVet.Helpers;

namespace testsVet.Services
{
    public class AnimalCtests
    {
        [Test]
        public async Task GetAllAsync_ReturnsAnimals()
        {
            var context = TestDbFactory.CreateContext();
            AnimalController controller = new AnimalController(context);
            context.Animals.Add(new Animal { Type = "Dog" });
            await context.SaveChangesAsync();

            var result = await controller.GetAllAsync();

            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task CreateAsync_AddsAnimal()
        {
            var context = TestDbFactory.CreateContext();
            AnimalController controller = new AnimalController(context);
            await controller.CreateAsync(new Animal { Type = "Cat" });

            Assert.That(context.Animals.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task UpdateAsync_UpdatesAnimal()
        {
            var context = TestDbFactory.CreateContext();
            AnimalController controller = new AnimalController(context);
            var animal = new Animal { Type = "Dog" };

            context.Animals.Add(animal);
            await context.SaveChangesAsync();

            animal.Type = "Bird";

            await controller.UpdateAsync(animal);

            Assert.That(context.Animals.First().Type, Is.EqualTo("Bird"));
        }
        [Test]
        public async Task DeleteAsync_RemovesAnimal()
        {
            var context = TestDbFactory.CreateContext();
            AnimalController controller = new AnimalController(context);
            var animal = new Animal { Type = "Dog" };

            context.Animals.Add(animal);
            await context.SaveChangesAsync();

            await controller.DeleteAsync(animal.Id);

            Assert.That(context.Animals.Count(), Is.EqualTo(0));
        }
    }
}
