using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.DataAccess
{
    public class DriversRepository
    {
        private readonly DatabaseContext _context;

        public DriversRepository(DatabaseContext context)
        {
            _context = context;
        }

        public DriversRepository()
        {
            _context = new DatabaseContext();
        }

        public List<Driver> GetAllDrivers()
        {
            return _context.Drivers.ToList();
        }

        public Driver GetDriverById(int id)
        {
            return _context.Drivers.FirstOrDefault(d => d.DriverID == id);
        }

        public void AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        public void UpdateDriver(Driver driver)
        {
            _context.Entry(driver).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteDriver(int id)
        {
            var driver = GetDriverById(id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                _context.SaveChanges();
            }
        }

        // Новий метод для фільтрації водіїв за районами роботи
        public List<Driver> GetDriversByWorkingArea(string workingArea)
        {
            return _context.Drivers.Where(d => d.WorkingAreas.Contains(workingArea)).ToList();
        }
    }
}
