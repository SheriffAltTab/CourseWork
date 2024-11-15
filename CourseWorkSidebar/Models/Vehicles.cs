namespace CourseWorkSidebar.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        // Посилання на водія
        public int? DriverID { get; set; }

        // Нове посилання на майстра, який обслуговує автомобіль
        public int? AssignedMaster { get; set; }
    }
}
