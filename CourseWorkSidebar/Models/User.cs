using System;

namespace CourseWorkSidebar.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }

        public User() { }

        public User(int userID, string username, string passwordHash)
        {
            UserID = userID;
            Username = username;
            PasswordHash = passwordHash;
        }
    }
}
