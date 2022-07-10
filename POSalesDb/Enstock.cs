using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Enstock
    {
        public int Id { get; set; }
        public string refno { get; set; }
        public string pcode { get; set; }
        public int qty { get; set; }
        public DateTime sdate { get; set; }
        public string stockinby { get; set; }
        public string status { get; set; }
        public string supplierId { get; set; }
    }
}
