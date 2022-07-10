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
    public partial class Group : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Group()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());

        }

        public void cargarGrupo()
        {
            int i = 0;
            dgvGroup.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Grupo ORDER BY nombre", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvGroup.Rows.Add(i, dr["id"].ToString(), dr["nombre"].ToString());
            }
            dr.Close();
            cn.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GroupModule module = new GroupModule(this);
            module.ShowDialog();
        }

        private void dgvGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvGroup.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Estas seguro de eliminar este grupo ?", "Eliminar grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM Marcas WHERE id LIKE '" + dgvGroup[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Grupo eliminado con exito.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else if (colName == "Edit")
            {
                GroupModule grModule = new GroupModule(this);
                grModule.lblId.Text = dgvGroup[1, e.RowIndex].Value.ToString();
                grModule.txtGroup.Text = dgvGroup[2, e.RowIndex].Value.ToString();
                grModule.btnSave.Enabled = false;
                grModule.btnUpdate.Enabled = true;
                grModule.ShowDialog();
            }
            cargarGrupo();
        }
    }
}
