using POSalesDb;
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
    public partial class Item : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
         DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public Item()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            cargarItem();
        }
        public void cargarItem()
        {
            using (var repo = new Repository(new SqlConnection(dbcon.myConnection())))
            {
                dgvItem.Rows.Clear();
                dgvItem.DataSource = repo.GetAll<Items>("Items");
            }
        }
        
        private void dgvBodega_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string colName = dgvItem.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                ItemModule item = new ItemModule(this);
                item.txtIdProd.Text = dgvItem.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                item.txtNameProdcut.Text = dgvItem.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                item.txtCodUno.Text = dgvItem.Rows[e.RowIndex].Cells["codigoUno"].Value.ToString();
                item.txtCodDos.Text = dgvItem.Rows[e.RowIndex].Cells["codigoDos"].Value.ToString();
                item.txtCod3.Text = dgvItem.Rows[e.RowIndex].Cells["codigoTres"].Value.ToString();
                item.txtCod4.Text = dgvItem.Rows[e.RowIndex].Cells["codigoCuatro"].Value.ToString();
                item.txtBarcode.Text = dgvItem.Rows[e.RowIndex].Cells["codigoBarras"].Value.ToString();
                item.txtPriceA.Text = dgvItem.Rows[e.RowIndex].Cells["precioA"].Value.ToString();
                item.txtPriceB.Text = dgvItem.Rows[e.RowIndex].Cells["precioB"].Value.ToString();
                item.txtPriceC.Text = dgvItem.Rows[e.RowIndex].Cells["precioC"].Value.ToString();
                item.txtPriceD.Text = dgvItem.Rows[e.RowIndex].Cells["precioD"].Value.ToString();
                item.txtPriceD.Text = dgvItem.Rows[e.RowIndex].Cells["precioD"].Value.ToString();
                item.txtReason.Text = dgvItem.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
                item.txtPesoItem.Text = dgvItem.Rows[e.RowIndex].Cells["peso"].Value.ToString();
                item.txtComision.Text = dgvItem.Rows[e.RowIndex].Cells["comision"].Value.ToString();
                item.txtDescMax.Text = dgvItem.Rows[e.RowIndex].Cells["descMax"].Value.ToString();
                item.txtStockMax.Text = dgvItem.Rows[e.RowIndex].Cells["stockMax"].Value.ToString();
                item.txtStockMin.Text = dgvItem.Rows[e.RowIndex].Cells["stockMin"].Value.ToString();
                item.txtCosto.Text = dgvItem.Rows[e.RowIndex].Cells["costo"].Value.ToString();
                item.txtUnidad.Text = dgvItem.Rows[e.RowIndex].Cells["unidad"].Value.ToString();
                item.cboBodega.SelectedIndex = Convert.ToInt32 (dgvItem.Rows[e.RowIndex].Cells["bId"].Value.ToString());
                item.cboCategory.SelectedIndex = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells["CId"].Value.ToString());
                item.cboGroup.SelectedIndex = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells["gId"].Value.ToString());
                item.cboBrand.SelectedIndex = Convert.ToInt32(dgvItem.Rows[e.RowIndex].Cells["mId"].Value.ToString());
                item.chckServicio.Checked = dgvItem.Rows[e.RowIndex].Cells["servicio"].Value.ToString() == "1";
                item.chckAplicaSeries.Checked = dgvItem.Rows[e.RowIndex].Cells["aplicaSeries"].Value.ToString() == "1";
                item.chckNegativo.Checked = dgvItem.Rows[e.RowIndex].Cells["negativo"].Value.ToString() == "1";
                item.chckCombo.Checked = dgvItem.Rows[e.RowIndex].Cells["Combo"].Value.ToString() == "1";
                item.chkGasto.Checked = dgvItem.Rows[e.RowIndex].Cells["Gasto"].Value.ToString() == "1";
                item.txtIce.Text = dgvItem.Rows[e.RowIndex].Cells["ice"].Value.ToString();
                item.txtValorIce.Text = dgvItem.Rows[e.RowIndex].Cells["valorIce"].Value.ToString();
                item.txtIva.Text = dgvItem.Rows[e.RowIndex].Cells["iva"].Value.ToString();
                item.HasIva.Checked = dgvItem.Rows[e.RowIndex].Cells["HasIva"].Value.ToString() == "1";
                item.txtCatA.Text = dgvItem.Rows[e.RowIndex].Cells["categoriaA"].Value.ToString();
                item.txtCatB.Text = dgvItem.Rows[e.RowIndex].Cells["categoriaB"].Value.ToString();
                item.txtCatC.Text = dgvItem.Rows[e.RowIndex].Cells["categoriaC"].Value.ToString();
                item.txtCatD.Text = dgvItem.Rows[e.RowIndex].Cells["categoriaD"].Value.ToString();
                item.txtCatE.Text = dgvItem.Rows[e.RowIndex].Cells["categoriaE"].Value.ToString();
                item.picItem.Visible = false;
                item.picBrowse.Visible = false;
                item.btnSave.Enabled = false;
                item.ShowDialog();
            
            
            }
            else if (colName == "Delete")
            {
                dgvItem.DataSource = null;
                if (MessageBox.Show("Estas seguro de eliminar este Item?", "Eliminar Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM Bodega WHERE id LIKE '" + dgvItem["id", e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item eliminado con exito.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            cargarItem();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ItemModule productModule = new ItemModule(this);
            productModule.ShowDialog();
        }
    }
}
