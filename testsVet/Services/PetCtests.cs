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
    public class PetCtests
    {
        [Test]
        public async Task GetAllAsync_ReturnsPets()
        {
            var context = TestDbFactory.CreateContext();
            PetController controller = new PetController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName="nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            context.Pets.Add(new Pet
            {
                Name = "Rex",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            });

            await context.SaveChangesAsync();

            var result = await controller.GetAllAsync();

            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task CreateAsync_AddsPet()
        {
            var context = TestDbFactory.CreateContext();
            PetController controller = new PetController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Breed",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Rex",
                Age = 3,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            await controller.CreateAsync(pet);

            Assert.That(context.Pets.Count(), Is.EqualTo(1));
        }

        [Test]
        public async Task UpdateAsync_UpdatesPet()
        {
            var context = TestDbFactory.CreateContext();
            PetController controller = new PetController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Breed",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "OldName",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            await context.SaveChangesAsync();

            pet.Name = "NewName";

            await controller.UpdateAsync(pet);

            var updatedPet = context.Pets.First();

            Assert.That(updatedPet.Name, Is.EqualTo("NewName"));
        }

        [Test]
        public async Task DeleteAsync_RemovesPet()
        {
            var context = TestDbFactory.CreateContext();
            PetController controller = new PetController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Breed",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Pet",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            await context.SaveChangesAsync();

            await controller.DeleteAsync(pet.Id);

            Assert.That(context.Pets.Count(), Is.EqualTo(0));
        }
    }
}
