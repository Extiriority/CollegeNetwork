using System;
using CollegeNetwork.tests.stubData;
using CollegeNetworkBackend1.Lib.Logic.User;
using NUnit.Framework;

namespace CollegeNetwork.tests
{
    public class Tests
    {
  
    
        private readonly User validUser1 = new User()
        {  
            id = 4, 
            firstName = "fourth", 
            lastName = "Duke", 
            email = "Damm@won.net",
            phoneNumber = "0694813584", 
            dateOfBirth = new DateTime(1999, 7, 05), 
            gender = "other",
            password = "bruh3", 
            isAdmin = false
        };
    
        [Test]
        public void getById_MockUsers_AreEqual()
        {
        
            // Arrange
            AuthControllerStub authControllerStub = new();
            //UserRepository userRepository = new()



        }
    }
}