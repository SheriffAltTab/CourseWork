using System;

namespace CourseWorkSidebar.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int? DriverID { get; set; }
        public int? AssignedMaster { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public string LastServiceDetails { get; set; }
    }
}
