using System.Collections.Generic;
using System.Data.Entity;
using System.Runtime.Remoting.Contexts;
using CourseWorkSidebar.Models;

namespace CourseWorkSidebar.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("name=CourseWorkDB")
        {
        }

        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Master> Masters { get; set; }
        public virtual DbSet<Operator> Operators { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Fault> Faults { get; set; }
    }
}
