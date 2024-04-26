using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuochoa.Model
{
    public class BillDetailsInfo
    {
        public int ID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
       // public string BillCode { get; set; }
        public int? Amount { get; set; }
        public double? UnitPrice { get; set; }
        public double? Discount { get; set; }
        public double? IntoMoney { get; set; }
    }
}
