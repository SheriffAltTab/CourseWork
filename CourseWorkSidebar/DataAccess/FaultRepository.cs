using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.DataAccess
{
    public class FaultRepository
    {
        private readonly DatabaseContext _context;

        public FaultRepository()
        {
            _context = new DatabaseContext();
        }

        public List<Fault> GetAllFaults()
        {
            return _context.Faults.ToList();
        }

        public Fault GetFaultById(int id)
        {
            return _context.Faults.FirstOrDefault(f => f.FaultID == id);
        }

        public void AddFault(Fault fault)
        {
            _context.Faults.Add(fault);
            _context.SaveChanges();
        }

        public void DeleteFault(int id)
        {
            var fault = GetFaultById(id);
            if (fault != null)
            {
                _context.Faults.Remove(fault);
                _context.SaveChanges();
            }
        }
    }
}
