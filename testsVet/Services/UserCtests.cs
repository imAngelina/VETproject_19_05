using CONTROLLERproject;
using DATAproject.Entities;
using DATAproject.Enums;
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
    }
}
