using System;
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
            if (string.IsNullOrWhiteSpace(driver.FirstName) || string.IsNullOrWhiteSpace(driver.LastName) ||
                driver.BirthDate == default(DateTime) || string.IsNullOrWhiteSpace(driver.LicenseNumber) ||
                driver.HireDate == default(DateTime) || string.IsNullOrWhiteSpace(driver.WorkingDays) || 
                string.IsNullOrWhiteSpace(driver.WorkingAreas))
            {
                throw new InvalidOperationException("Некоректні дані для водія. Усі поля повинні бути заповнені.");
            }

            if (_context.Drivers.Any(d => d.LicenseNumber == driver.LicenseNumber))
            {
                throw new System.InvalidOperationException("Водій з таким номером водійського посвідення вже існує.");
            }

            _context.Drivers.Add(driver);
            _context.SaveChanges();
        }

        public void UpdateDriver(Driver driver)
        {
            var existingDriver = _context.Drivers.Find(driver.DriverID);
            if (existingDriver == null)
            {
                throw new InvalidOperationException("Водій не знайдений.");
            }

            // Оновлюємо властивості існуючого водія
            existingDriver.FirstName = driver.FirstName;
            existingDriver.LastName = driver.LastName;
            existingDriver.BirthDate = driver.BirthDate;
            existingDriver.LicenseNumber = driver.LicenseNumber;
            existingDriver.HireDate = driver.HireDate;
            existingDriver.WorkingDays = driver.WorkingDays;
            existingDriver.WorkingAreas = driver.WorkingAreas;

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
        public List<Driver> GetDriversByWorkingArea(string workingArea)
        {
            return _context.Drivers.Where(d => d.WorkingAreas.Contains(workingArea)).ToList();
        }
    }
}
