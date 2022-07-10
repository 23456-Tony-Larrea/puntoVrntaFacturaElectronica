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
   
    public partial class BodegaModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Bodega bdg;
        public BodegaModule(Bodega bd)
        {
            cn = new SqlConnection(dbcon.myConnection());
            InitializeComponent();
            bdg = bd;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
                this.Dispose();
          

        }

       
        public void Clear()
        {
            txtBodega.Clear();
            txtBodega.Focus();
            btnGuardarCat.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de actualizar esta bodega?", "Actualizado con exito!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Bodega SET nombre = @nombre WHERE id LIKE'" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@nombre", txtBodega.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Categoria Actualizada con exito.", "punto de venta");
                Clear();
                this.Dispose();// To close this form after update data
            }
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro de guardar esta bodega?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO Bodega (nombre)VALUES(@nombre)", cn);
                    cm.Parameters.AddWithValue("@nombre", txtBodega.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bodega guardada con exito ", "Punto de venta");
                    Clear();
                    this.Dispose();
                }
                bdg.CargarBodega();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
