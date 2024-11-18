using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;
using System.Linq;
using System;

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
                new Vehicle { VehicleID = 1, LicensePlate = "AB123CD", Brand = "Toyota", Model = "Corolla", Year = 2020, LastServiceDate = DateTime.Now.AddMonths(-1), LastServiceDetails = "Oil change" }
            };
            _mockVehiclesDbSet = MockHelpers.CreateMockDbSet(vehicles);
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Vehicles).Returns(_mockVehiclesDbSet.Object);
            _repository = new VehiclesRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddVehicle_WhenCalled_AddsVehicleToContext()
        {
            // Arrange
            var vehicle = new Vehicle { VehicleID = 2, LicensePlate = "XY456ZT", Brand = "Honda", Model = "Civic", Year = 2019 };

            // Act
            _repository.AddVehicle(vehicle);

            // Assert
            _mockVehiclesDbSet.Verify(m => m.Add(It.IsAny<Vehicle>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
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
        public void GetVehicleById_WhenCalled_ReturnsCorrectVehicle()
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
    }
}
