using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;
using System.Linq;

namespace CourseWorkSidebar.Tests
{
    [TestClass]
    public class UserRepositoryTests
    {
        private Mock<DbSet<User>> _mockUsersDbSet;
        private Mock<DatabaseContext> _mockContext;
        private UserRepository _repository;

        [TestInitialize]
        public void SetUp()
        {
            _mockUsersDbSet = MockHelpers.CreateMockDbSet(new List<User>());
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Users).Returns(_mockUsersDbSet.Object);
            _repository = new UserRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddUser_WhenCalled_AddsUserToContext()
        {
            // Arrange
            var user = new User { UserID = 1, Username = "testuser", PasswordHash = "hashedpassword" };

            // Act
            _repository.AddUser(user);

            // Assert
            _mockUsersDbSet.Verify(m => m.Add(It.IsAny<User>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void IsUsernameTaken_WhenUserExists_ReturnsTrue()
        {
            // Arrange
            var users = new List<User>
            {
                new User { UserID = 1, Username = "testuser", PasswordHash = "hashedpassword" }
            };
            _mockUsersDbSet = MockHelpers.CreateMockDbSet(users);
            _mockContext.Setup(m => m.Users).Returns(_mockUsersDbSet.Object);

            // Act
            var result = _repository.IsUsernameTaken("testuser");

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void AuthenticateUser_WhenCredentialsAreCorrect_ReturnsTrue()
        {
            // Arrange
            var user = new User { UserID = 1, Username = "testuser", PasswordHash = BCrypt.Net.BCrypt.HashPassword("password") };
            var users = new List<User> { user };
            _mockUsersDbSet = MockHelpers.CreateMockDbSet(users);
            _mockContext.Setup(m => m.Users).Returns(_mockUsersDbSet.Object);

            // Act
            var result = _repository.AuthenticateUser("testuser", "password");

            // Assert
            Assert.IsTrue(result);
        }
    }
}
