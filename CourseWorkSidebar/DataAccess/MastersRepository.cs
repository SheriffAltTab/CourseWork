using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CourseWorkSidebar.Models;

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
            _context.Masters.Add(master);
            _context.SaveChanges();
        }

        public void UpdateMaster(Master master)
        {
            _context.Entry(master).State = EntityState.Modified;
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
