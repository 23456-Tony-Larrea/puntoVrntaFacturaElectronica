using POSalesDB;
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

namespace POSales
{
    public partial class Bodega : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;


        public Bodega()
        {
            cn = new SqlConnection(dbcon.myConnection());
            InitializeComponent();
            CargarBodega();
        }

        public void CargarBodega()
        {
            int i = 0;
            dgvBodega.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Bodega ORDER BY nombre", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvBodega.Rows.Add(i, dr["id"].ToString(), dr["marca"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BodegaModule bodegaModule = new BodegaModule(this);
            bodegaModule.ShowDialog();
        }

        private void dgvBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvBodega.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Estas seguro de eliminar esta bodega ?", "Eliminar marca", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM Bodega WHERE id LIKE '" + dgvBodega[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Marca eliminada con exito.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {
                BodegaModule bdgModulo = new BodegaModule(this);
                bdgModulo.lblId.Text = dgvBodega[1, e.RowIndex].Value.ToString();
                bdgModulo.txtBodega.Text = dgvBodega[2, e.RowIndex].Value.ToString();
                bdgModulo.btnGuardarCat.Enabled = false;
                bdgModulo.btnUpdate.Enabled = true;
                bdgModulo.ShowDialog();
            }
            CargarBodega();
        }
    }
    }
