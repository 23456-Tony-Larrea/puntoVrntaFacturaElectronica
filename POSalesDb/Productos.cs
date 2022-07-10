using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Productos
    {
        public string codigo { get; set; }
        public string codigoBarras { get; set; }
        public string pDesc { get; set; }
        public int bid { get; set; }
        public int cid { get; set; }
        public decimal precio { get; set; }
        public int cantidad { get; set; }
        public int reorder { get; set; }
    }
}
