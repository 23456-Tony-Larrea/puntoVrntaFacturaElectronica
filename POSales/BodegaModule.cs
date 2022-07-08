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
    public partial class BodegaModule : Form
    {
        public BodegaModule()
        {
            InitializeComponent();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
                this.Dispose();
          

        }

        private void txtGroup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
