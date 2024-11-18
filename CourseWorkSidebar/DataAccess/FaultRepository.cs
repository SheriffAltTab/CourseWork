using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.DataAccess
{
    public class FaultRepository
    {
        private readonly DatabaseContext _context;

        public FaultRepository(DatabaseContext context)
        {
            _context = context;
        }

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
            if (fault.DriverID <= 0 || fault.VehicleID <= 0 || string.IsNullOrWhiteSpace(fault.Description) || fault.ReportDate == default(DateTime))
            {
                throw new InvalidOperationException("Некоректні дані для несправності. Усі поля повинні бути заповнені.");
            }

            if (_context.Faults.Any(f => f.FaultID == fault.FaultID))
            {
                throw new InvalidOperationException("Несправність з таким ID вже існує.");
            }

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
