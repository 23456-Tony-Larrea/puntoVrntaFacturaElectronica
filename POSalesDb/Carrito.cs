using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Carrito
    {
        public int Id { get; set; }
        public string trasnno { get; set; }
        public string pcode{ get; set; }
        public decimal price { get; set; }
        public int cantidad { get; set; }
        public decimal disc_percent { get; set; }
        public decimal disc { get; set; }
        public decimal total { get; set; }
        public DateTime sdate { get; set; }
        public string status { get; set; }
        public string cashier { get; set; }
    }
}
