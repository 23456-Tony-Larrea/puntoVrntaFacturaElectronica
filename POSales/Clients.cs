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
    public partial class Clients : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Clients()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cargarClientes(); 
        }

        public void cargarClientes()
        {
            int i = 0;
            dgvClients.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Clientes ORDER BY nombre", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvClients.Rows.Add(i,dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(),dr[8].ToString(), dr[9].ToString(), dr[10].ToString(),dr[11].ToString(), dr[12].ToString(), dr[13].ToString(), dr[14].ToString(), dr[15].ToString(), dr[16].ToString());

            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClientModule clientModule = new ClientModule(this);
            clientModule.ShowDialog();
        }
    }
}
