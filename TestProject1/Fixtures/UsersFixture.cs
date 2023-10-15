using CloudCustomers.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.Fixtures
{
    public static class UsersFixture
    {
        public static List<User> GetTestUsers() =>
            new()
            {
                new User()
                {
                    Id = 1,
                        Name = "robot",
                        Address = new Address()
                        {
                            Street = "caldas da rainha",
                            City = "BH",
                            ZipCode = "31255"
                        },
                        Email = "robot@robot.com"
                },
                new User()
                {
                    Id = 2,
                        Name = "robot2",
                        Address = new Address()
                        {
                            Street = "caldas da rainha2",
                            City = "BH2",
                            ZipCode = "31255"
                        },
                        Email = "robot2@robot.com"
                }
            };
    }
}
