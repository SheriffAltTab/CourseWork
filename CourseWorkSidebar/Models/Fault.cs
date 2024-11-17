using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWorkSidebar.Models
{
    public class Fault
    {
        public int FaultID { get; set; }
        public int DriverID { get; set; }
        public int VehicleID { get; set; }
        public string Description { get; set; }
        public DateTime ReportDate { get; set; }
    }
}

