using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlycafenew.Extensions
{
    public static class ConvertDateTime
    {
        public static string ConvertDatetimeToString(this DateTime date) => date.ToString("MM/dd/yyyy");

    }
}
