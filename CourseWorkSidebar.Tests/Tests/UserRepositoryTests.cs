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
            var user = new User { UserID = 1, Username = "testuser", PasswordHash = "hashedpassword", Role = "Адміністратор" };

            // Act
            _repository.AddUser(user);

            // Assert
            _mockUsersDbSet.Verify(m => m.Add(It.IsAny<User>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void AddUser_WithDifferentRoles_AddsUserToContext()
        {
            // Arrange
            var admin = new User { UserID = 1, Username = "adminuser", PasswordHash = "hashedpassword", Role = "Адміністратор" };
            var driver = new User { UserID = 2, Username = "driveruser", PasswordHash = "hashedpassword", Role = "Водій" };
            var operatorUser = new User { UserID = 3, Username = "operatoruser", PasswordHash = "hashedpassword", Role = "Оператор" };

            // Act
            _repository.AddUser(admin);
            _repository.AddUser(driver);
            _repository.AddUser(operatorUser);

            // Assert
            _mockUsersDbSet.Verify(m => m.Add(It.IsAny<User>()), Times.Exactly(3));
            _mockContext.Verify(m => m.SaveChanges(), Times.Exactly(3));
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

        [TestMethod]
        public void AuthenticateUser_WithDifferentRoles_ReturnsTrueForCorrectCredentials()
        {
            // Arrange
            var admin = new User { UserID = 1, Username = "adminuser", PasswordHash = BCrypt.Net.BCrypt.HashPassword("adminpassword"), Role = "Адміністратор" };
            var driver = new User { UserID = 2, Username = "driveruser", PasswordHash = BCrypt.Net.BCrypt.HashPassword("driverpassword"), Role = "Водій" };
            var operatorUser = new User { UserID = 3, Username = "operatoruser", PasswordHash = BCrypt.Net.BCrypt.HashPassword("operatorpassword"), Role = "Оператор" };
            var users = new List<User> { admin, driver, operatorUser };
            _mockUsersDbSet = MockHelpers.CreateMockDbSet(users);
            _mockContext.Setup(m => m.Users).Returns(_mockUsersDbSet.Object);

            // Act
            var adminResult = _repository.AuthenticateUser("adminuser", "adminpassword");
            var driverResult = _repository.AuthenticateUser("driveruser", "driverpassword");
            var operatorResult = _repository.AuthenticateUser("operatoruser", "operatorpassword");

            // Assert
            Assert.IsTrue(adminResult);
            Assert.IsTrue(driverResult);
            Assert.IsTrue(operatorResult);
        }

        [TestMethod]
        public void IsUsernameTaken_WhenUserDoesNotExist_ReturnsFalse()
        {
            // Arrange
            var users = new List<User>();
            _mockUsersDbSet = MockHelpers.CreateMockDbSet(users);
            _mockContext.Setup(m => m.Users).Returns(_mockUsersDbSet.Object);

            // Act
            var result = _repository.IsUsernameTaken("nonexistentuser");

            // Assert
            Assert.IsFalse(result);
        }
    }
}
