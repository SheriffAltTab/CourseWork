using System.Collections.Generic;
using System;

namespace CourseWorkSidebar.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string LicenseNumber { get; set; }
        public DateTime HireDate { get; set; }
    }
}
