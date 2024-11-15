using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;

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

        // Отримати всіх операторів
        public List<Operator> GetAllOperators()
        {
            return _context.Operators.ToList();
        }

        // Отримати оператора за ID
        public Operator GetOperatorById(int id)
        {
            return _context.Operators.FirstOrDefault(o => o.OperatorID == id);
        }

        // Додати нового оператора
        public void AddOperator(Operator @operator)
        {
            if (_context.Operators != null)
            {
                _context.Operators.Add(@operator);
                _context.SaveChanges();
            }
        }

        // Оновити інформацію про оператора
        public void UpdateOperator(Operator @operator)
        {
            if (_context.Entry(@operator) != null)
            {
                _context.Entry(@operator).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }

        // Видалити оператора за ID
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
