using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;
using static ReaLTaiizor.Controls.ExtendedPanel;

namespace CourseWorkSidebar.DataAccess
{
    public class OperatorsRepository
    {
        private readonly DatabaseContext _context;
        public OperatorsRepository(DatabaseContext context)
        {
            _context = context;
        }

        public OperatorsRepository()
        {
            _context = new DatabaseContext();
        }

        public List<Operator> GetAllOperators()
        {
            return _context.Operators.ToList();
        }

        public Operator GetOperatorById(int id)
        {
            return _context.Operators.FirstOrDefault(o => o.OperatorID == id);
        }
        public void AddOperator(Operator @operator)
        {
            if (string.IsNullOrWhiteSpace(@operator.FirstName) || string.IsNullOrWhiteSpace(@operator.LastName) ||
            @operator.BirthDate == default(DateTime) || @operator.HireDate == default(DateTime) || 
            string.IsNullOrWhiteSpace(@operator.WorkingDays))
            {
                throw new InvalidOperationException("Некоректні дані для оператора. Усі поля повинні бути заповнені.");
            }

            _context.Operators.Add(@operator);
            _context.SaveChanges();
        }

        public void UpdateOperator(Operator @operator)
        {
            var existingOperator = _context.Operators.Find(@operator.OperatorID);
            if (existingOperator == null)
            {
                throw new InvalidOperationException("Оператор не знайдений.");
            }

            // Оновлюємо властивості існуючого оператора
            existingOperator.FirstName = @operator.FirstName;
            existingOperator.LastName = @operator.LastName;
            existingOperator.BirthDate = @operator.BirthDate;
            existingOperator.HireDate = @operator.HireDate;
            existingOperator.WorkingDays = @operator.WorkingDays;

            _context.SaveChanges();
        }

        public void DeleteOperator(int id)
        {
            var @operator = GetOperatorById(id);
            if (@operator != null && _context.Operators != null)
            {
                _context.Operators.Remove(@operator);
                _context.SaveChanges();
            }
        }
    }
}
