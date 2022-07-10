using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Cancel
    {
        public int Id { get; set; }
        public string transno { get; set; }
        public string pcode { get; set; }
        public decimal price { get; set; }
        public int qty { get; set; }
        public decimal total { get; set; }
        public DateTime sdate { get; set; }
        public string voidby { get; set; }
        public string cancelledby { get; set; }
        public string reason { get; set; }
        public string action { get; set; }

    }
}
