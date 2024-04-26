using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuochoa.Model
{
    public class SalaryInfo
    {
        public int ID { get; set; }
        public string StaffCode { get; set; }
        public string StaffName { get; set; }
        public int? HoursWork { get; set; }
        public double? Bonus { get; set; }
        public double? TotalSalary { get; set; }
    }
}
