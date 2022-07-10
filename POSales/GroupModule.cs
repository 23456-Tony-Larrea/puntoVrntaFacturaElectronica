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
    public partial class GroupModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        Group group;
        public GroupModule( Group gr)
        {
            cn = new SqlConnection(dbcon.myConnection());

            InitializeComponent();
            group = gr;
        }

        private void GroupModule_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Estas seguro de guardar este grupo?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO Grupo(nombre)VALUES(@nombre)", cn);
                    cm.Parameters.AddWithValue("@nombre", txtGroup.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Existosamente guardado.", "POS");
                    Clear();
                    group.cargarGrupo();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        public void Clear()
        {
            txtGroup.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtGroup.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de actualizar este grupo?", "Actualizado con exito!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE Grupo SET nombre = @nombre WHERE id LIKE'" + lblId.Text + "'", cn);
                cm.Parameters.AddWithValue("@nombre", txtGroup.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Marca actualizada con exito.", "POS");
                Clear();
                this.Dispose();// To close this form after update data
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
