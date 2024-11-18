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
                new Operator { OperatorID = 1, FirstName = "Іван", LastName = "Сидоренко", BirthDate = new DateTime(1990, 1, 1), HireDate = new DateTime(2022, 1, 1), WorkingDays = "Пн, Вт, Ср" }
            };
            _mockOperatorsDbSet = MockHelpers.CreateMockDbSet(operators);
            _mockContext = new Mock<DatabaseContext>();
            _mockContext.Setup(m => m.Operators).Returns(_mockOperatorsDbSet.Object);
            _repository = new OperatorsRepository(_mockContext.Object);
        }

        [TestMethod]
        public void AddOperator_WhenCalledWithValidData_AddsOperatorToContext()
        {
            // Arrange
            var @operator = new Operator { OperatorID = 2, FirstName = "Ольга", LastName = "Петренко", BirthDate = new DateTime(1992, 2, 2), HireDate = new DateTime(2022, 2, 2), WorkingDays = "Чт, Пт" };

            // Act
            _repository.AddOperator(@operator);

            // Assert
            _mockOperatorsDbSet.Verify(m => m.Add(It.IsAny<Operator>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void AddOperator_WhenCalledWithInvalidData_ThrowsException()
        {
            // Arrange
            var @operator = new Operator { OperatorID = 2, FirstName = "", LastName = "", BirthDate = new DateTime(), HireDate = new DateTime(), WorkingDays = "" };

            // Act
            _repository.AddOperator(@operator);
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
            var @operator = new Operator { OperatorID = 1, FirstName = "Іван", LastName = "Сидоренко", BirthDate = new DateTime(1990, 1, 1), HireDate = new DateTime(2022, 1, 1) };
            _mockOperatorsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(@operator);

            // Act
            _repository.DeleteOperator(1);

            // Assert
            _mockOperatorsDbSet.Verify(m => m.Remove(It.IsAny<Operator>()), Times.Once);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }

        [TestMethod]
        public void GetOperatorById_WhenOperatorExists_ReturnsOperator()
        {
            // Arrange
            var @operator = new Operator { OperatorID = 1, FirstName = "Іван", LastName = "Сидоренко", BirthDate = new DateTime(1990, 1, 1), HireDate = new DateTime(2022, 1, 1) };
            _mockOperatorsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(@operator);

            // Act
            var result = _repository.GetOperatorById(1);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.OperatorID);
        }

        [TestMethod]
        public void GetOperatorById_WhenOperatorDoesNotExist_ReturnsNull()
        {
            // Arrange
            _mockOperatorsDbSet = MockHelpers.CreateMockDbSet(new List<Operator>());
            _mockContext.Setup(m => m.Operators).Returns(_mockOperatorsDbSet.Object);
            _mockOperatorsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns((Operator)null);

            // Act
            var result = _repository.GetOperatorById(1);

            // Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void UpdateOperator_WhenCalledWithValidData_UpdatesOperatorInContext()
        {
            // Arrange
            var @operator = new Operator { OperatorID = 1, FirstName = "Іван", LastName = "Сидоренко", BirthDate = new DateTime(1990, 1, 1), HireDate = new DateTime(2022, 1, 1) };
            _mockOperatorsDbSet.Setup(m => m.Find(It.IsAny<int>())).Returns(@operator);

            // Act
            @operator.LastName = "Петренко";
            _repository.UpdateOperator(@operator);

            // Assert
            Assert.AreEqual("Петренко", @operator.LastName);
            _mockContext.Verify(m => m.SaveChanges(), Times.Once);
        }
    }
}
