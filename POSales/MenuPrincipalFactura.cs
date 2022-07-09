using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSales
{
    public partial class MenuPrincipalFactura : Form
    {
        public MenuPrincipalFactura()
        {
            InitializeComponent();
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            FacturaClientes factura = new FacturaClientes();
            factura.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picClientes_Click(object sender, EventArgs e)
        {
            ClientModule clientModule = new ClientModule(new Clients());
            clientModule.ShowDialog();
           
        }
    }
}
