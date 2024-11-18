using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.Tests
{
    [TestClass]
    public class FaultRepositoryTests
    {
        private Mock<DbSet<Fault>> _mockFaultsDbSet;
        private Mock<DatabaseContext> _mockContext;
        private FaultRepository _repository;

        [TestInitialize]
        public void SetUp()
        {
            var faults = new List<Fault>
            {
                new Fault { FaultID = 1, DriverID = 1, VehicleID = 1, Description = "Engine issue", ReportDate = System.DateTime.Now }
            };
            _mockFaultsDbSet = MockHelpers.CreateMockDbSet(faults);
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Faults).Returns(_mockFaultsDbSet.Object);
            _repository = new FaultRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddFault_WhenCalled_AddsFaultToContext()
        {
            // Arrange
            var fault = new Fault { FaultID = 2, DriverID = 2, VehicleID = 2, Description = "Brake issue", ReportDate = System.DateTime.Now };

            // Act
            _repository.AddFault(fault);

            // Assert
            _mockFaultsDbSet.Verify(m => m.Add(It.IsAny<Fault>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetAllFaults_WhenCalled_ReturnsAllFaults()
        {
            // Act
            var result = _repository.GetAllFaults();

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void DeleteFault_WhenFaultExists_RemovesFaultFromContext()
        {
            // Arrange
            var fault = new Fault { FaultID = 1, DriverID = 1, VehicleID = 1, Description = "Engine issue", ReportDate = System.DateTime.Now };
            _mockFaultsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(fault);

            // Act
            _repository.DeleteFault(1);

            // Assert
            _mockFaultsDbSet.Verify(m => m.Remove(It.IsAny<Fault>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetFaultById_WhenFaultExists_ReturnsCorrectFault()
        {
            // Arrange
            var fault = new Fault { FaultID = 1, DriverID = 1, VehicleID = 1, Description = "Engine issue", ReportDate = System.DateTime.Now };
            _mockFaultsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(fault);

            // Act
            var result = _repository.GetFaultById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.FaultID);
        }

        [TestMethod]
        public void GetFaultById_WhenFaultDoesNotExist_ReturnsNull()
        {
            // Act
            var result = _repository.GetFaultById(99);

            // Assert
            Assert.IsNull(result);
        }
    }
}
