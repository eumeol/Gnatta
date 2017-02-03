using Microsoft.VisualStudio.TestTools.UnitTesting;
using SocialMediaWebApi.Controllers;
using SocialMediaWebApi.Models;
using System.Collections.Generic;
using Telerik.JustMock;

namespace SocialMediaApplication.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Should_Get_One_User()
        {
            //Arrange
            var userRepository = Mock.Create<IUserRepository>();
            Mock.Arrange(() => userRepository.GetUsers()).
                Returns(new List<User>()
                {    new User { Name="Name1", Login=1,Avatar_Url ="https://avatars/1", Location="UK"}
                        ,new User { Name="Name2", Login=2,Avatar_Url ="https://avatars/2", Location="NI"}
                        ,new User { Name="Name3", Login=3,Avatar_Url ="https://avatars/3", Location="EU"}
                }).MustBeCalled();

            //Act
            var controller = new UsersController(userRepository);
            var expected = controller.Get(1);

            //Assert
            Assert.AreEqual("Name1", expected.Name);
        }


        [TestMethod]
        public void Should_Get_All_Users()
        {
            //Arrange
              var userRepository = Mock.Create<IUserRepository>();
                Mock.Arrange(() => userRepository.GetUsers()).
                    Returns(new List<User>()
                    {    new User { Name="Name1", Login=1,Avatar_Url ="https://avatars/1", Location="UK"}
                        ,new User { Name="Name2", Login=2,Avatar_Url ="https://avatars/2", Location="NI"}
                        ,new User { Name="Name3", Login=3,Avatar_Url ="https://avatars/3", Location="EU"}
                    }).MustBeCalled();

            //Act
            var controller = new UsersController(userRepository);
            var expected = controller.Get();

            //Assert
            Assert.AreEqual(3, expected.Count);
        }       
      
    }
}
