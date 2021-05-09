using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using WordPressNetCore.Controllers;
using WordPressNetCore.Models;
using WordPressNetCore.Repositories;

namespace WordPressNetCore.Tests.Repositories
{
    public class UserControllerTests
    {
        Mock<IUserRepository> _repository;
        UserController _controller;
        List<User> _users;

        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IUserRepository>();
            _controller = new UserController(_repository.Object);

            _users = new List<User>();
            _users.Add(new User { Id  = 1, Password = "pwd1", UserName = "usr1" });
            _users.Add(new User { Id = 2, Password = "pwd2", UserName = "usr2" });
            _users.Add(new User { Id = 3, Password = "pwd3", UserName = "usr3" });
        }

        [Test]
        public void Get_ReturnsAllUsers()
        {
            // Setup
            _repository.Setup(e => e.GetAll()).Returns(_users);
            
            // Act
            var result = _controller.Get();

            // Asserts
            _repository.Verify(e => e.GetAll());
            Assert.That(result, Is.InstanceOf<IEnumerable<User>>());
            Assert.That(result, Has.Count.GreaterThan(0));
        }
    }
}
