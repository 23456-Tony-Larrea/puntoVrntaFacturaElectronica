using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Inventario
    {
        public int Id_inventario { get; set; }
        public int producto { get; set; }
        public int cantidad { get; set; }
        public int alamacen { get; set; }
        public string tipo { get; set; }
        public DateTime fecha_inventario { get; set; }
    }
}
