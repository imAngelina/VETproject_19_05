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
    public class AppointmentCtests
    {
        [Test]
        public async Task CreateAppointmentAsync_ReturnsTrue_WhenFree()
        {
            var context = TestDbFactory.CreateContext();
            AppointmentController controller = new AppointmentController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName="nz"
            };

            var employee = new Userr
            {
                Username = "doctor",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Users.Add(employee);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Rex",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            var service = new Service
            {
                Name = "Checkup",
                Price = 50
            };

            context.Services.Add(service);

            await context.SaveChangesAsync();

            var appointment = new Appointment
            {
                PetId = pet.Id,
                EmployeeId = employee.Id,
                ServiceId = service.Id,
                DateTime = DateTime.Now.AddHours(1),
                Reason = "Regular checkup"
            };

            var result = await controller.CreateAppointmentAsync(appointment);

            Assert.That(result, Is.True);
            Assert.That(context.Appointments.Count(), Is.EqualTo(1));
        }
        [Test]
        public async Task GetAllAsync_ReturnsAppointments()
        {
            var context = TestDbFactory.CreateContext();
            AppointmentController controller = new AppointmentController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var employee = new Userr
            {
                Username = "doctor",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Users.Add(employee);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Rex",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            var service = new Service
            {
                Name = "Checkup",
                Price = 50
            };

            context.Services.Add(service);

            await context.SaveChangesAsync();

            context.Appointments.Add(new Appointment
            {
                PetId = pet.Id,
                EmployeeId = employee.Id,
                ServiceId = service.Id,
                DateTime = DateTime.Now,
                Reason = "Checkup"
            });

            await context.SaveChangesAsync();

            var result = await controller.GetAllAsync();

            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task GetClientAppointmentsAsync_ReturnsAppointments()
        {
            var context = TestDbFactory.CreateContext();
            AppointmentController controller = new AppointmentController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var employee = new Userr
            {
                Username = "doctor",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Users.Add(employee);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Rex",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            var service = new Service
            {
                Name = "Checkup",
                Price = 50
            };

            context.Services.Add(service);

            await context.SaveChangesAsync();

            context.Appointments.Add(new Appointment
            {
                PetId = pet.Id,
                EmployeeId = employee.Id,
                ServiceId = service.Id,
                DateTime = DateTime.Now,
                Reason = "Vaccination"
            });

            await context.SaveChangesAsync();

            var result = await controller.GetClientAppointmentsAsync(owner.Id);

            Assert.That(result.Count, Is.EqualTo(1));
        }

        [Test]
        public async Task IsAppointmentTakenAsync_ReturnsTrue_WhenTaken()
        {
            var context = TestDbFactory.CreateContext();
            AppointmentController controller = new AppointmentController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var employee = new Userr
            {
                Username = "doctor",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Users.Add(employee);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Rex",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            var service = new Service
            {
                Name = "Checkup",
                Price = 50
            };

            context.Services.Add(service);

            await context.SaveChangesAsync();

            var appointmentDate = DateTime.Now;

            context.Appointments.Add(new Appointment
            {
                PetId = pet.Id,
                EmployeeId = employee.Id,
                ServiceId = service.Id,
                DateTime = appointmentDate,
                Reason = "Checkup"
            });

            await context.SaveChangesAsync();

            var result = await controller.IsAppointmentTakenAsync(
                appointmentDate,
                employee.Id);

            Assert.That(result, Is.True);
        }

        [Test]
        public async Task CreateAppointmentAsync_ReturnsFalse_WhenTaken()
        {
            var context = TestDbFactory.CreateContext();
            AppointmentController controller = new AppointmentController(context);
            var owner = new Userr
            {
                Username = "owner",
                Password = "123",
                FullName = "nz"
            };

            var employee = new Userr
            {
                Username = "doctor",
                Password = "123",
                FullName = "nz"
            };

            var animal = new Animal
            {
                Type = "Dog"
            };

            context.Users.Add(owner);
            context.Users.Add(employee);
            context.Animals.Add(animal);

            await context.SaveChangesAsync();

            var breed = new Breed
            {
                Name = "Husky",
                AnimalId = animal.Id
            };

            context.Breeds.Add(breed);

            await context.SaveChangesAsync();

            var pet = new Pet
            {
                Name = "Rex",
                Age = 2,
                OwnerId = owner.Id,
                BreedId = breed.Id
            };

            context.Pets.Add(pet);

            var service = new Service
            {
                Name = "Checkup",
                Price = 50
            };

            context.Services.Add(service);

            await context.SaveChangesAsync();

            var appointmentDate = DateTime.Now;

            context.Appointments.Add(new Appointment
            {
                PetId = pet.Id,
                EmployeeId = employee.Id,
                ServiceId = service.Id,
                DateTime = appointmentDate,
                Reason = "Checkup"
            });

            await context.SaveChangesAsync();

            var result = await controller.CreateAppointmentAsync(
                new Appointment
                {
                    PetId = pet.Id,
                    EmployeeId = employee.Id,
                    ServiceId = service.Id,
                    DateTime = appointmentDate,
                    Reason = "Another checkup"
                });

            Assert.That(result, Is.False);
        }

        
    }
}
