using System;
using System.Collections.Generic;
using System.Linq;
using CollegeNetworkBackend1.Lib.Data;
using CollegeNetworkBackend1.Lib.Logic.User;

namespace CollegeNetwork.tests.stubData
{
    public class AuthControllerStub : IUserRepository
    {
        private List<User> userList = new()
        {
            new User
            {
                id = 1, firstName = "Tom", lastName = "Hanks", email = "Tommy@live.nl", phoneNumber = "0695847911",
                dateOfBirth = new DateTime(2000, 12, 21), gender = "Male", password = "test", isAdmin = false
            },
            new User
            {
                id = 2, firstName = "Roos", lastName = "dijck", email = "Roosje@hart.nl", phoneNumber = "0694836745",
                dateOfBirth = new DateTime(1988, 5, 3), gender = "female",
                password = "53B945B392DFC50FBDA2B803A0F9E7388420F094665BD31A1AE22DBC3D1F5482", isAdmin = false
            },
            new User
            {
                id = 3, firstName = "Willy", lastName = "Alex", email = "Wellempje@game.net",
                phoneNumber = "0694856384", dateOfBirth = new DateTime(1995, 7, 18), gender = "other",
                password = "2AEB9015B14196CCA87359FE32103AC60593D5E9F78793298F001E2225B17877", isAdmin = false
            }
        };

        public User create(User user)
        {
            int index = userList.FindLastIndex(c => c.id == user.id);
            if (index != -1)
            {
                userList[index] = new User()
                {
                    id = user.id,
                    firstName = user.firstName,
                    lastName = user.lastName,
                    email = user.email,
                    phoneNumber = user.phoneNumber,
                    dateOfBirth = user.dateOfBirth,
                    gender = user.gender,
                    password = user.password,
                    isAdmin = user.isAdmin
                };
            }

            return user;
        }

        public User getByEmail(string email)
        {
            User user = userList.Single(x => x.email == email);
            return user;
        }

        public User getById(int id)
        {
            User user = userList.Single(x => x.id == id);
            return user;
        }
    }
}