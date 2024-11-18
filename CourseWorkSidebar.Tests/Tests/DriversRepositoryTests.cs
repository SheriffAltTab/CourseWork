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
    public class DriversRepositoryTests
    {
        private Mock<DbSet<Driver>> _mockDriversDbSet;
        private Mock<DatabaseContext> _mockContext;
        private DriversRepository _repository;

        [TestInitialize]
        public void SetUp()
        {
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(new List<Driver>());
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);
            _repository = new DriversRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddDriver_WhenCalled_AddsDriverToContext()
        {
            // Arrange
            var driver = new Driver
            {
                DriverID = 1,
                FirstName = "John",
                LastName = "Doe",
                BirthDate = new System.DateTime(1985, 1, 1),
                LicenseNumber = "A123456",
                HireDate = System.DateTime.Now,
                WorkingDays = "Пн, Вт, Ср",
                WorkingAreas = "Центр, Дружба"
            };

            // Act
            _repository.AddDriver(driver);

            // Assert
            _mockDriversDbSet.Verify(m => m.Add(It.IsAny<Driver>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetAllDrivers_WhenCalled_ReturnsAllDrivers()
        {
            // Arrange
            var drivers = new List<Driver>
            {
                new Driver { DriverID = 1, FirstName = "John", LastName = "Doe" },
                new Driver { DriverID = 2, FirstName = "Jane", LastName = "Smith" }
            };
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(drivers);
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);

            // Act
            var result = _repository.GetAllDrivers();

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void DeleteDriver_WhenDriverExists_RemovesDriverFromContext()
        {
            // Arrange
            var driver = new Driver { DriverID = 1, FirstName = "John", LastName = "Doe" };
            var drivers = new List<Driver> { driver };
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(drivers);
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);
            _mockDriversDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(driver);

            // Act
            _repository.DeleteDriver(1);

            // Assert
            _mockDriversDbSet.Verify(m => m.Remove(It.IsAny<Driver>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetDriverById_WhenDriverExists_ReturnsDriver()
        {
            // Arrange
            var driver = new Driver { DriverID = 1, FirstName = "John", LastName = "Doe" };
            var drivers = new List<Driver> { driver };
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(drivers);
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);
            _mockDriversDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(driver);

            // Act
            var result = _repository.GetDriverById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("John", result.FirstName);
            Assert.AreEqual("Doe", result.LastName);
        }

        [TestMethod]
        public void GetDriverById_WhenDriverDoesNotExist_ReturnsNull()
        {
            // Arrange
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(new List<Driver>());
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);
            _mockDriversDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns((Driver)null);

            // Act
            var result = _repository.GetDriverById(1);

            // Assert
            Assert.IsNull(result);
        }
    }
}
