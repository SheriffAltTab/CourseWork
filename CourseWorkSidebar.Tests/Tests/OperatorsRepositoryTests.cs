using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Data.Entity;
using CourseWorkSidebar.DataAccess;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.Tests
{
    [TestClass]
    public class OperatorsRepositoryTests
    {
        private Mock<DbSet<Operator>> _mockOperatorsDbSet;
        private Mock<DatabaseContext> _mockContext;
        private OperatorsRepository _repository;

        [TestInitialize]
        public void SetUp()
        {
            var operators = new List<Operator>
            {
                new Operator { OperatorID = 1, FirstName = "John", LastName = "Smith", BirthDate = new System.DateTime(1990, 1, 1), HireDate = new System.DateTime(2022, 1, 1) }
            };
            _mockOperatorsDbSet = MockHelpers.CreateMockDbSet(operators);
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Operators).Returns(_mockOperatorsDbSet.Object);
            _repository = new OperatorsRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddOperator_WhenCalled_AddsOperatorToContext()
        {
            // Arrange
            var @operator = new Operator { OperatorID = 2, FirstName = "Jane", LastName = "Doe", BirthDate = new System.DateTime(1992, 2, 2), HireDate = new System.DateTime(2022, 2, 2) };

            // Act
            _repository.AddOperator(@operator);

            // Assert
            _mockOperatorsDbSet.Verify(m => m.Add(It.IsAny<Operator>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetAllOperators_WhenCalled_ReturnsAllOperators()
        {
            // Act
            var result = _repository.GetAllOperators();

            // Assert
            Assert.AreEqual(1, result.Count);
        }

        [TestMethod]
        public void DeleteOperator_WhenOperatorExists_RemovesOperatorFromContext()
        {
            // Arrange
            var @operator = new Operator { OperatorID = 1, FirstName = "John", LastName = "Smith", BirthDate = new System.DateTime(1990, 1, 1), HireDate = new System.DateTime(2022, 1, 1) };
            _mockOperatorsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(@operator);

            // Act
            _repository.DeleteOperator(1);

            // Assert
            _mockOperatorsDbSet.Verify(m => m.Remove(It.IsAny<Operator>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
