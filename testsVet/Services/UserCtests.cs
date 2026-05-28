using CONTROLLERproject;
using DATAproject;
using DATAproject.Entities;
using DATAproject.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testsVet.Helpers;

namespace testsVet.Services
{
    public class UserCtests
    {
        //private var context = TestDbFactory.CreateContext();
        //private UserController controller = new UserController(context);

        //[SetUp]
        //public void Setup()
        //{
        //    context = TestDbFactory.CreateContext();
        //    controller = new UserController(context);
        //}
        [Test]
        public async Task Login_User_1()
        {
            var context = TestDbFactory.CreateContext();
            context.Users.Add(new Userr
            {
                Username = "ani",
                Password = "123",
                FullName = "angelina",
                Role = UserRole.Admin
            });
            await context.SaveChangesAsync();
            UserController controller = new UserController(context);
            Userr user = await controller.LoginAsync("ani","123");
            Assert.IsNotNull(user);
            Assert.AreEqual("ani",user.Username);
        }
        [Test]
        public async Task GetAllAsync_ReturnsAllUsers()
        {
            var context = TestDbFactory.CreateContext();
            UserController controller = new UserController(context);
            context.Users.Add(new Userr
            {
                Username = "test",
                Password = "123",
                FullName = "Test User"
            });

            await context.SaveChangesAsync();

            var result = await controller.GetAllAsync();

            Assert.That(result.Count, Is.EqualTo(1));
        }
        [Test]
        public async Task CreateAsync_AddsUser()
        {
            var context = TestDbFactory.CreateContext();
            UserController controller = new UserController(context);
            var user = new Userr
            {
                Username = "newuser",
                Password = "pass",
                FullName="nz"
            };

            await controller.CreateAsync(user);

            Assert.That(context.Users.Count(), Is.EqualTo(1));
        }
        [Test]
        public async Task UpdateAsync_UpdatesUser()
        {
            var context = TestDbFactory.CreateContext();
            UserController controller = new UserController(context);
            var user = new Userr
            {
                Username = "old",
                Password = "123",
                FullName="nz"
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();

            user.Username = "new";

            await controller.UpdateAsync(user);

            var updated = context.Users.First();

            Assert.That(updated.Username, Is.EqualTo("new"));
        }
        [Test]
        public async Task DeleteAsync_RemovesUser()
        {
            var context = TestDbFactory.CreateContext();
             UserController controller = new UserController(context);
            var user = new Userr
            {
                Username = "delete",
                Password = "123",
                FullName = "nz"
            };

            context.Users.Add(user);
            await context.SaveChangesAsync();

            await controller.DeleteAsync(user.Id);

            Assert.That(context.Users.Count(), Is.EqualTo(0));
        }
    }
}
