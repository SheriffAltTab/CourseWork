using System.Linq;
using CourseWorkSidebar.Models;
using System.Data.Entity;
using BCrypt.Net;

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

        // Перевірка на існування імені користувача
        public bool IsUsernameTaken(string username)
        {
            return _context.Users?.Any(u => u.Username == username) ?? false;
        }

        // Додавання нового користувача з хешованим паролем
        public void AddUser(User user)
        {
            if (_context.Users != null)
            {
                user.PasswordHash = HashPassword(user.PasswordHash);
                _context.Users.Add(user);
                _context.SaveChanges();
            }
        }

        // Аутентифікація користувача з перевіркою пароля через BCrypt
        public bool AuthenticateUser(string username, string password)
        {
            var user = _context.Users?.FirstOrDefault(u => u.Username == username);
            if (user == null) return false;

            return VerifyPassword(password, user.PasswordHash);
        }

        // Хешування пароля через BCrypt
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        // Перевірка пароля через BCrypt
        private bool VerifyPassword(string password, string passwordHash)
        {
            return BCrypt.Net.BCrypt.Verify(password, passwordHash);
        }
    }
}
