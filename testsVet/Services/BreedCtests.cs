using CONTROLLERproject;
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
    public class BreedCtests
    {
        [Test]
        public async Task GetAllAsync_ReturnsBreeds()
        {
            var context = TestDbFactory.CreateContext();
            BreedController controller = new BreedController(context);
            var animal = new Animal { Type = "Dog" };
            context.Animals.Add(animal);
            await context.SaveChangesAsync();

            context.Breeds.Add(new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            });

            await context.SaveChangesAsync();

            var result = await controller.GetAllAsync();

            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task CreateAsync_AddsBreed()
        {
            var context = TestDbFactory.CreateContext();
            BreedController controller = new BreedController(context);
            var animal = new Animal { Type = "Dog" };
            context.Animals.Add(animal);
            await context.SaveChangesAsync();

            await controller.CreateAsync(new Breed
            {
                Name = "Bulldog",
                AnimalId = animal.Id
            });

            Assert.That(context.Breeds.Count(), Is.EqualTo(1));
        }
        [Test]
        public async Task UpdateAsync_UpdatesBreed()
        {
            var context = TestDbFactory.CreateContext();
            BreedController controller = new BreedController(context);
            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Animals.Add(animal);
            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "OldBreed",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);
            await context.SaveChangesAsync();

            breed.Name = "NewBreed";

            await controller.UpdateAsync(breed);

            var updatedBreed = context.Breeds.First();

            Assert.That(updatedBreed.Name, Is.EqualTo("NewBreed"));
        }
        [Test]
        public async Task DeleteAsync_RemovesBreed()
        {
            var context = TestDbFactory.CreateContext();
            BreedController controller = new BreedController(context);
            var animal = new Animal { Type = "Dog" };
            context.Animals.Add(animal);
            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Breed",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);
            await context.SaveChangesAsync();

            await controller.DeleteAsync(breed.Id);

            Assert.That(context.Breeds.Count(), Is.EqualTo(0));
        }
    }
}
