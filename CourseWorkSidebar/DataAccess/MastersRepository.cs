using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;
using static ReaLTaiizor.Controls.ExtendedPanel;

namespace CourseWorkSidebar.DataAccess
{
    public class MastersRepository
    {
        private readonly DatabaseContext _context;

        public MastersRepository(DatabaseContext context)
        {
            _context = context;
        }

        public MastersRepository()
        {
            _context = new DatabaseContext();
        }

        public List<Master> GetAllMasters()
        {
            return _context.Masters.ToList();
        }

        public Master GetMasterById(int id)
        {
            return _context.Masters.FirstOrDefault(m => m.MasterID == id);
        }
        public void AddMaster(Master master)
        {
            if (string.IsNullOrWhiteSpace(master.FirstName) || string.IsNullOrWhiteSpace(master.LastName) ||
            master.BirthDate == default(DateTime) || master.HireDate == default(DateTime) || 
            string.IsNullOrWhiteSpace(master.Specialty) ||string.IsNullOrWhiteSpace(master.WorkingDays))
            {
                throw new InvalidOperationException("Некоректні дані для майстра. Усі поля повинні бути заповнені.");
            }

            _context.Masters.Add(master);
            _context.SaveChanges();
        }

        public void UpdateMaster(Master master)
        {
            var existingMaster = _context.Masters.Find(master.MasterID);
            if (existingMaster == null)
            {
                throw new InvalidOperationException("Майстер не знайдений.");
            }

            // Оновлюємо властивості існуючого майстра
            existingMaster.FirstName = master.FirstName;
            existingMaster.LastName = master.LastName;
            existingMaster.BirthDate = master.BirthDate;
            existingMaster.HireDate = master.HireDate;
            existingMaster.Specialty = master.Specialty;
            existingMaster.WorkingDays = master.WorkingDays;

            _context.SaveChanges();
        }

        public void DeleteMaster(int id)
        {
            var master = GetMasterById(id);
            if (master != null)
            {
                _context.Masters.Remove(master);
                _context.SaveChanges();
            }
        }

        public List<Master> SortMastersBy(string sortBy, bool ascending)
        {
            switch (sortBy)
            {
                case "Ім'я":
                    return ascending ? _context.Masters.OrderBy(m => m.FirstName).ToList() : _context.Masters.OrderByDescending(m => m.FirstName).ToList();
                case "Прізвище":
                    return ascending ? _context.Masters.OrderBy(m => m.LastName).ToList() : _context.Masters.OrderByDescending(m => m.LastName).ToList();
                case "Дата народження":
                    return ascending ? _context.Masters.OrderBy(m => m.BirthDate).ToList() : _context.Masters.OrderByDescending(m => m.BirthDate).ToList();
                case "Дата прийняття на роботу":
                    return ascending ? _context.Masters.OrderBy(m => m.HireDate).ToList() : _context.Masters.OrderByDescending(m => m.HireDate).ToList();
                case "ID":
                    return ascending ? _context.Masters.OrderBy(m => m.MasterID).ToList() : _context.Masters.OrderByDescending(m => m.MasterID).ToList();
                default:
                    return _context.Masters.ToList();
            }
        }
    }
}
