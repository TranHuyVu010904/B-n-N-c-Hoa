using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuochoa.Model
{
    public class BillInfo
    {
        public int ID { get; set; }
        public string CustomerCode { get; set; }
        public string SfaffCode { get; set; }
        public DateTime? DOS { get; set; }
        public double? Total { get; set; }
    }
}
