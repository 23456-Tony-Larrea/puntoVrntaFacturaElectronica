using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSalesDB;
namespace POSales
{
    public partial class FacturaClientes : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataAdapter dr;

        public FacturaClientes()
        {
            cn = new SqlConnection(dbcon.myConnection());
            InitializeComponent();
            GetRefNo();
            cargarCliente();
            cargarUsuario();
            cargarProductos();
            
          
        }

        public void cargarCliente()
        {
            cboClientes.Items.Clear();
            cboClientes.DataSource = dbcon.getTable("select * from Clientes");
            cboClientes.DisplayMember = "nombre";
            cboClientes.ValueMember = "Id";
        }

        public void cargarUsuario()
        {
            cboRegistrado.Items.Clear();
            cboRegistrado.DataSource = dbcon.getTable("select * from Usuarios");
            cboRegistrado.DisplayMember = "username";
            cboRegistrado.ValueMember = "username";
        }
        public void cargarProductos()
        {
            cboProductos.Items.Clear();
            cboProductos.DataSource = dbcon.getTable("select * from Marcas");
            cboProductos.DisplayMember = "marca";
            cboProductos.ValueMember = "id";
        }

        public void GetRefNo()
        {
            Random rnd= new Random();
            txtCodigo.Clear();
            txtCodigo.Text += rnd.Next();

        }
    }
}
