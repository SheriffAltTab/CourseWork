using System;
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
        public void AddDriver_WhenCalledWithValidData_AddsDriverToContext()
        {
            // Arrange
            var driver = new Driver
            {
                DriverID = 1,
                FirstName = "Олександр",
                LastName = "Ковальчук",
                BirthDate = new DateTime(1985, 1, 1),
                LicenseNumber = "A123456",
                HireDate = DateTime.Now,
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
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddDriver_WhenCalledWithInvalidData_ThrowsException()
        {
            // Arrange
            var driver = new Driver
            {
                DriverID = 1,
                FirstName = "",
                LastName = "",
                BirthDate = new DateTime(),
                LicenseNumber = "",
                HireDate = DateTime.Now,
                WorkingDays = "",
                WorkingAreas = ""
            };

            // Act
            _repository.AddDriver(driver);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddDriver_WhenCalledWithExistingLicenseNumber_ThrowsException()
        {
            // Arrange
            var existingDriver = new Driver
            {
                DriverID = 1,
                FirstName = "Олександр",
                LastName = "Ковальчук",
                LicenseNumber = "A123456",
                BirthDate = new DateTime(1985, 1, 1),
                HireDate = DateTime.Now,
                WorkingDays = "Пн, Вт, Ср",
                WorkingAreas = "Центр, Дружба"
            };
            var drivers = new List<Driver> { existingDriver };
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(drivers);
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);

            var newDriver = new Driver
            {
                DriverID = 2,
                FirstName = "Іван",
                LastName = "Петренко",
                LicenseNumber = "A123456",
                BirthDate = new DateTime(1990, 1, 1),
                HireDate = DateTime.Now,
                WorkingDays = "Пн, Вт, Ср",
                WorkingAreas = "Аляска"
            };

            // Act
            _repository.AddDriver(newDriver);
        }

        [TestMethod]
        public void GetAllDrivers_WhenCalled_ReturnsAllDrivers()
        {
            // Arrange
            var drivers = new List<Driver>
            {
                new Driver { DriverID = 1, FirstName = "Олександр", LastName = "Ковальчук" },
                new Driver { DriverID = 2, FirstName = "Іван", LastName = "Петренко" }
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
            var driver = new Driver { DriverID = 1, FirstName = "Олександр", LastName = "Ковальчук" };
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
            var driver = new Driver { DriverID = 1, FirstName = "Олександр", LastName = "Ковальчук" };
            var drivers = new List<Driver> { driver };
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(drivers);
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);
            _mockDriversDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(driver);

            // Act
            var result = _repository.GetDriverById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Олександр", result.FirstName);
            Assert.AreEqual("Ковальчук", result.LastName);
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

        [TestMethod]
        public void UpdateDriver_WhenCalledWithValidData_UpdatesDriverInContext()
        {
            // Arrange
            var driver = new Driver { DriverID = 1, FirstName = "Олександр", LastName = "Ковальчук", LicenseNumber = "A123456" };
            var drivers = new List<Driver> { driver };
            _mockDriversDbSet = MockHelpers.CreateMockDbSet(drivers);
            _mockContext.Setup(m => m.Drivers).Returns(_mockDriversDbSet.Object);
            _mockDriversDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(driver);

            // Act
            driver.LastName = "Петренко";
            _repository.UpdateDriver(driver);

            // Assert
            Assert.AreEqual("Петренко", driver.LastName);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

    }
}
