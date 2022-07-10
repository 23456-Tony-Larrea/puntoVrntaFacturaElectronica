using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POSalesDb
{
    internal class Provedeedores
    {
        public int Id { get; set; }
        public string proveedor { get; set; }
        public string direccion { get; set; }
        public string contactPerson { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string RazonSocial { get; set; }
        public string cedulaRuc { get; set; }
        public int DiasCredito { get; set; }
        public string estado { get; set; }
        public string ciudad { get; set; }
        public string pais{ get; set; }
        public string provincia { get; set; }
        public string codPostal { get; set; }
        public string paginaWeb { get; set; }

    }
}
