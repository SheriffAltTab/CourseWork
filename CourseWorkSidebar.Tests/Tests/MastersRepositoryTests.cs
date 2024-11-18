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
    public class MastersRepositoryTests
    {
        private Mock<DbSet<Master>> _mockMastersDbSet;
        private Mock<DatabaseContext> _mockContext;
        private MastersRepository _repository;

        [TestInitialize]
        public void SetUp()
        {
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(new List<Master>());
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);
            _repository = new MastersRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddMaster_WhenCalledWithValidData_AddsMasterToContext()
        {
            // Arrange
            var master = new Master
            {
                MasterID = 2,
                FirstName = "Іван",
                LastName = "Шевченко",
                BirthDate = new DateTime(1980, 5, 12),
                HireDate = new DateTime(2022, 3, 1),
                Specialty = "Механік",
                WorkingDays = "Пн"
            };

            // Act
            _repository.AddMaster(master);

            // Assert
            _mockMastersDbSet.Verify(m => m.Add(It.IsAny<Master>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddMaster_WhenCalledWithInvalidData_ThrowsException()
        {
            // Arrange
            var master = new Master
            {
                MasterID = 3,
                FirstName = "",
                LastName = "",
                BirthDate = new DateTime(), // Некоректна дата
                HireDate = new DateTime(),  // Некоректна дата
                Specialty = ""
            };

            // Act
            _repository.AddMaster(master);
        }

        [TestMethod]
        public void GetAllMasters_WhenCalled_ReturnsAllMasters()
        {
            // Arrange
            var masters = new List<Master>
            {
                new Master { MasterID = 1, FirstName = "Петро", LastName = "Коваленко" },
                new Master { MasterID = 2, FirstName = "Іван", LastName = "Шевченко" }
            };
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(masters);
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);

            // Act
            var result = _repository.GetAllMasters();

            // Assert
            Assert.AreEqual(2, result.Count);
        }

        [TestMethod]
        public void DeleteMaster_WhenMasterExists_RemovesMasterFromContext()
        {
            // Arrange
            var master = new Master { MasterID = 1, FirstName = "Петро", LastName = "Коваленко" };
            var masters = new List<Master> { master };
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(masters);
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);
            _mockMastersDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(master);

            // Act
            _repository.DeleteMaster(1);

            // Assert
            _mockMastersDbSet.Verify(m => m.Remove(It.IsAny<Master>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetMasterById_WhenMasterExists_ReturnsMaster()
        {
            // Arrange
            var master = new Master { MasterID = 1, FirstName = "Петро", LastName = "Коваленко" };
            var masters = new List<Master> { master };
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(masters);
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);
            _mockMastersDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(master);

            // Act
            var result = _repository.GetMasterById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Петро", result.FirstName);
            Assert.AreEqual("Коваленко", result.LastName);
        }

        [TestMethod]
        public void GetMasterById_WhenMasterDoesNotExist_ReturnsNull()
        {
            // Arrange
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(new List<Master>());
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);
            _mockMastersDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns((Master)null);

            // Act
            var result = _repository.GetMasterById(1);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateMaster_WhenCalledWithValidData_UpdatesMasterInContext()
        {
            // Arrange
            var master = new Master { MasterID = 1, FirstName = "Петро", LastName = "Коваленко", Specialty = "Механік" };
            var masters = new List<Master> { master };
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(masters);
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);
            _mockMastersDbSet.Setup(m => m.Find(master.MasterID)).Returns(master);

            // Act
            master.Specialty = "Електрик";
            _repository.UpdateMaster(master);

            // Assert
            Assert.AreEqual("Електрик", master.Specialty);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
