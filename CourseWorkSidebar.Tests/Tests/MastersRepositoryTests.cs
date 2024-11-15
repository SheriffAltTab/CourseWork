using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

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
            var masters = new List<Master>
            {
                new Master { MasterID = 1, FirstName = "John", LastName = "Doe", BirthDate = new System.DateTime(1990, 1, 1), HireDate = new System.DateTime(2022, 1, 1), Specialty = "Mechanic" }
            };
            _mockMastersDbSet = MockHelpers.CreateMockDbSet(masters);
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Masters).Returns(_mockMastersDbSet.Object);
            _repository = new MastersRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddMaster_WhenCalled_AddsMasterToContext()
        {
            // Arrange
            var master = new Master { MasterID = 2, FirstName = "Jane", LastName = "Smith", BirthDate = new System.DateTime(1992, 2, 2), HireDate = new System.DateTime(2022, 2, 2), Specialty = "Electrician" };

            // Act
            _repository.AddMaster(master);

            // Assert
            _mockMastersDbSet.Verify(m => m.Add(It.IsAny<Master>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetAllMasters_WhenCalled_ReturnsAllMasters()
        {
            // Act
            var result = _repository.GetAllMasters();

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void DeleteMaster_WhenMasterExists_RemovesMasterFromContext()
        {
            // Arrange
            var master = new Master { MasterID = 1, FirstName = "John", LastName = "Doe", BirthDate = new System.DateTime(1990, 1, 1), HireDate = new System.DateTime(2022, 1, 1), Specialty = "Mechanic" };
            _mockMastersDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(master);

            // Act
            _repository.DeleteMaster(1);

            // Assert
            _mockMastersDbSet.Verify(m => m.Remove(It.IsAny<Master>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
