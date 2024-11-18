using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.Tests
{
    [TestClass]
    public class VehiclesRepositoryTests
    {
        private Mock<DbSet<Vehicle>> _mockVehiclesDbSet;
        private Mock<DatabaseContext> _mockContext;
        private VehiclesRepository _repository;

        [TestInitialize]
        public void SetUp()
        {
            var vehicles = new List<Vehicle>
            {
                new Vehicle { VehicleID = 1, LicensePlate = "AB123CD", Brand = "Toyota", Model = "Corolla", Year = 2020, LastServiceDate = DateTime.Now.AddMonths(-1), LastServiceDetails = "Заміна масла" }
            };
            _mockVehiclesDbSet = MockHelpers.CreateMockDbSet(vehicles);
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Vehicles).Returns(_mockVehiclesDbSet.Object);
            _repository = new VehiclesRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddVehicle_WhenCalledWithValidData_AddsVehicleToContext()
        {
            // Arrange
            var vehicle = new Vehicle 
            { 
                VehicleID = 2,
                LicensePlate = "XY456ZT",
                Brand = "Honda",
                Model = "Civic",
                Year = 2019,
                LastServiceDate = DateTime.Now,
                LastServiceDetails = "Заміна масла"
            };

            // Act
            _repository.AddVehicle(vehicle);

            // Assert
            _mockVehiclesDbSet.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddVehicle_WhenCalledWithInvalidData_ThrowsException()
        {
            // Arrange
            var vehicle = new Vehicle { VehicleID = 3, LicensePlate = "", Brand = "", Model = "", Year = 0 };

            // Act
            _repository.AddVehicle(vehicle);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddVehicle_WhenCalledWithExistingLicensePlate_ThrowsException()
        {
            // Arrange
            var existingVehicle = new Vehicle { VehicleID = 1, LicensePlate = "AB123CD", Brand = "Toyota", Model = "Corolla", Year = 2020 };
            var newVehicle = new Vehicle { VehicleID = 3, LicensePlate = "AB123CD", Brand = "Nissan", Model = "Leaf", Year = 2021 }; // Duplicate license plate

            // Act
            _repository.AddVehicle(newVehicle);
        }

        [TestMethod]
        public void GetAllVehicles_WhenCalled_ReturnsAllVehicles()
        {
            // Act
            var result = _repository.GetAllVehicles();

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void DeleteVehicle_WhenVehicleExists_RemovesVehicleFromContext()
        {
            // Arrange
            var vehicle = new Vehicle { VehicleID = 1, LicensePlate = "AB123CD", Brand = "Toyota", Model = "Corolla", Year = 2020 };
            _mockVehiclesDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(vehicle);

            // Act
            _repository.DeleteVehicle(1);

            // Assert
            _mockVehiclesDbSet.Verify(m => m.Remove(It.IsAny<Vehicle>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetVehicleById_WhenVehicleExists_ReturnsCorrectVehicle()
        {
            // Arrange
            var vehicle = new Vehicle { VehicleID = 1, LicensePlate = "AB123CD", Brand = "Toyota", Model = "Corolla", Year = 2020 };
            _mockVehiclesDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(vehicle);

            // Act
            var result = _repository.GetVehicleById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(vehicle.VehicleID, result.VehicleID);
        }

        [TestMethod]
        public void GetVehicleById_WhenVehicleDoesNotExist_ReturnsNull()
        {
            // Arrange
            _mockVehiclesDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns((Vehicle)null);

            // Act
            var result = _repository.GetVehicleById(99);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateVehicle_WhenCalledWithValidData_UpdatesVehicleInContext()
        {
            // Arrange
            var vehicle = new Vehicle { VehicleID = 1, LicensePlate = "AB123CD", Brand = "Toyota", Model = "Corolla", Year = 2020 };
            _mockVehiclesDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(vehicle);

            // Act
            vehicle.Brand = "Nissan";
            _repository.UpdateVehicle(vehicle);

            // Assert
            Assert.AreEqual("Nissan", vehicle.Brand);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
