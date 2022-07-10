using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Ajustamiento
    {
        public int Id { get; set; }
        public string referenceno { get; set; }
        public string pcode { get; set; }
        public int qty { get; set; }
        public string action { get; set; }
        public string remarks { get; set; }
        public DateTime date { get; set; }
        public string user { get; set; }

}
}
