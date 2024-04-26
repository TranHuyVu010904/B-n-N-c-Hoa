using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuochoa.Model
{
    public class CustomerInfo
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public DateTime? Age { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
