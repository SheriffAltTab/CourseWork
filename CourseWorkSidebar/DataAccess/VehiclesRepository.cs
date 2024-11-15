using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.DataAccess
{
    public class VehiclesRepository
    {
        private readonly DatabaseContext _context;

        public VehiclesRepository(DatabaseContext context)
        {
            _context = context;
        }

        public VehiclesRepository()
        {
            _context = new DatabaseContext();
        }

        public List<Vehicle> GetAllVehicles()
        {
            return _context.Vehicles.ToList();
        }

        public Vehicle GetVehicleById(int id)
        {
            return _context.Vehicles.FirstOrDefault(v => v.VehicleID == id);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            _context.Entry(vehicle).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteVehicle(int id)
        {
            var vehicle = GetVehicleById(id);
            if (vehicle != null)
            {
                _context.Vehicles.Remove(vehicle);
                _context.SaveChanges();
            }
        }

        // Додано метод для оновлення інформації про останнє технічне обслуговування
        public void UpdateVehicleServiceDetails(int vehicleId, DateTime serviceDate, string serviceDetails)
        {
            var vehicle = GetVehicleById(vehicleId);
            if (vehicle != null)
            {
                vehicle.LastServiceDate = serviceDate;
                vehicle.LastServiceDetails = serviceDetails;
                _context.Entry(vehicle).State = EntityState.Modified;
                _context.SaveChanges();
            }
        }
    }
}
