using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;
using static ReaLTaiizor.Controls.ExtendedPanel;

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
            if (string.IsNullOrWhiteSpace(vehicle.LicensePlate) || string.IsNullOrWhiteSpace(vehicle.Brand) ||
            string.IsNullOrWhiteSpace(vehicle.Model) || vehicle.LastServiceDate == default(DateTime) || string.IsNullOrWhiteSpace(vehicle.LastServiceDetails))
            {
                throw new InvalidOperationException("Некоректні дані для автомобіля. Усі поля повинні бути заповнені.");
            }

            if (_context.Vehicles.Any(d => d.LicensePlate == vehicle.LicensePlate))
            {
                throw new System.InvalidOperationException("Автомобіль з таким номерним знаком вже існує.");
            }

            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            var existingVehicle = _context.Vehicles.Find(vehicle.VehicleID);
            if (existingVehicle == null)
            {
                throw new InvalidOperationException("Автомобіль не знайдений.");
            }

            // Оновлюємо властивості існуючого автомобіля
            existingVehicle.LicensePlate = vehicle.LicensePlate;
            existingVehicle.Brand = vehicle.Brand;
            existingVehicle.Model = vehicle.Model;
            existingVehicle.Year = vehicle.Year;
            existingVehicle.DriverID = vehicle.DriverID;
            existingVehicle.AssignedMaster = vehicle.AssignedMaster;
            existingVehicle.LastServiceDate = vehicle.LastServiceDate;
            existingVehicle.LastServiceDetails = vehicle.LastServiceDetails;

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
