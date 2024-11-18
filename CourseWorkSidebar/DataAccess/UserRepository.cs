using System.Linq;
using CourseWorkSidebar.Models;
using System.Data.Entity;
using BCrypt.Net;
using System;

namespace CourseWorkSidebar.DataAccess
{
    public class UserRepository
    {
        private readonly DatabaseContext _context;
        public UserRepository(DatabaseContext context)
        {
            _context = context;
        }

        public UserRepository()
        {
            _context = new DatabaseContext();
        }

        public bool IsUsernameTaken(string username)
        {
            return _context.Users?.Any(u => u.Username == username) ?? false;
        }

        public void AddUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username) || string.IsNullOrWhiteSpace(user.PasswordHash) || string.IsNullOrWhiteSpace(user.Role))
            {
                throw new InvalidOperationException("Некоректні дані для користувача. Усі поля повинні бути заповнені.");
            }

            if (_context.Users != null)
            {
                user.PasswordHash = HashPassword(user.PasswordHash);

                if (string.IsNullOrEmpty(user.Role))
                {
                    user.Role = "Адміністратор";
                }

                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        public bool AuthenticateUser(string username, string password)
        {
            var user = _context.Users?.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;

            return VerifyPassword(password, user.PasswordHash);
        }

        public User GetUserByUsername(string username)
        {
            return _context.Users?.FirstOrDefault(u => u.Username == username);
        }

        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        private bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
