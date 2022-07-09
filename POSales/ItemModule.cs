
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSales
{
    public partial class ItemModule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        string stitle = "Punto de venta";
        Item product;
        public ItemModule(Item pd)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            product = pd;
            LoadBrand();
            LoadCategory();
            LoadBodega();
            LoadGroup();
        }

        public void LoadCategory()
        {
            cboCategory.Items.Clear();
            cboCategory.DataSource = dbcon.getTable("SELECT * FROM Categorias");
            cboCategory.DisplayMember = "categoria";
            cboCategory.ValueMember = "id";
        }

        public void LoadBrand()
        {
            cboBrand.Items.Clear();
            cboBrand.DataSource = dbcon.getTable("SELECT * FROM Marcas");
            cboBrand.DisplayMember = "marca";
            cboBrand.ValueMember = "id";
        }

        public void LoadBodega()
        {
            cboBodega.Items.Clear();
            cboBodega.DataSource = dbcon.getTable("SELECT * FROM Bodega");
            cboBodega.DisplayMember = "nombre";
            cboBodega.ValueMember = "id";

        }
        public void LoadGroup() 
        {
            cboGroup.Items.Clear();
            cboGroup.DataSource = dbcon.getTable("SELECT * FROM Grupo");
            cboGroup.DisplayMember = "nombre";
            cboGroup.ValueMember = "Id";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void Clear()
        {
            txtIdProd.Clear();
            txtBarcode.Clear();
            //txtPdesc.Clear();
            txtPriceD.Clear();
            cboBrand.SelectedIndex = 0;
            cboCategory.SelectedIndex = 0;
            //UDReOrder.Value = 1;
            
            txtIdProd.Enabled = false;
            txtIdProd.Focus();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picItem.Image.Save(ms, picItem.Image.RawFormat);
            byte[] bytes = ms.ToArray();

            try
            {

         
                if (MessageBox.Show("Estas seguro de guardar este producto?", "Producto Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("INSERT INTO Items(nombre, codigoUno, codigoDos, codigoTres,codigoCuatro, codigoBarras,precioA,precioB,precioC,precioD,descripcion,unidadCaja,peso,comision,descMax,stockMin,stockMax,costo,unidad,bId,cId,gId,mId,servicio,aplicaSeries,negativo,combo,ice,valorIce,imagen,imagenUrl,iva,montoTotal,HasIva,@categoriaA,@categoriaB,@categoriaC,@categoriaD,@categoriaE) VALUES (@nombre, @codigoUno, @codigoDos, @codigoTres,@codigoCuatro,@codigoBarras,@precioA,@precioB,@precioC,@precioD,@descripcion,@unidadCaja,@peso,@comision,@descMax,@stockMin,@stockMax,@costo,@unidad,@bId,@cId,@gId,@mId,@servicio,@aplicaSeries,@negativo,@combo,@ice,@valorIce,@imagen,@imagenUrl,@iva,@montoTotal,@HasIva,@categoriaA,@categoriaB,@categoriaC,@categoriaD,@categoriaE)", cn);
                    cm.Parameters.AddWithValue("@nombre", txtNameProdcut.Text);
                    cm.Parameters.AddWithValue("@codigoUno", txtCodUno.Text);
                    cm.Parameters.AddWithValue("@codigoDos", txtCodDos.Text);
                    cm.Parameters.AddWithValue("@codigoTres", txtCod3.Text);
                    cm.Parameters.AddWithValue("@codigoCuatro", txtCod4.Text);
                    cm.Parameters.AddWithValue("@codigoBarras", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@precioA", decimal.Parse(txtPriceA.Text));
                    cm.Parameters.AddWithValue("@precioB", decimal.Parse(txtPriceB.Text));
                    cm.Parameters.AddWithValue("@precioC", decimal.Parse(txtPriceC.Text));
                    cm.Parameters.AddWithValue("@precioD", decimal.Parse(txtPriceD.Text));
                    cm.Parameters.AddWithValue("@descripcion",txtReason.Text);
                    cm.Parameters.AddWithValue("@unidadCaja", int.Parse(txtUnidadCaja.Text));
                    cm.Parameters.AddWithValue("@peso", decimal.Parse(txtPesoItem.Text));
                    cm.Parameters.AddWithValue("@comision", decimal.Parse(txtComision.Text));
                    cm.Parameters.AddWithValue("@descMax", decimal.Parse(txtDescMax.Text));
                    cm.Parameters.AddWithValue("@stockMax", int.Parse(txtStockMax.Text));
                    cm.Parameters.AddWithValue("@stockMin", int.Parse(txtStockMin.Text));
                    cm.Parameters.AddWithValue("@costo", decimal.Parse(txtCosto.Text));
                    cm.Parameters.AddWithValue("@unidad", int.Parse(txtUnidad.Text));
                    cm.Parameters.AddWithValue("@bId", cboBodega.SelectedValue);
                    cm.Parameters.AddWithValue("@cId", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@gId", cboGroup.SelectedValue);
                    cm.Parameters.AddWithValue("@mId", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@servicio", chckServicio.Checked);
                    cm.Parameters.AddWithValue("@aplicaSeries", chckAplicaSeries.Checked);
                    cm.Parameters.AddWithValue("@negativo", chckNegativo.Checked);
                    cm.Parameters.AddWithValue("@combo", chckCombo.Checked);
                    cm.Parameters.AddWithValue("@gasto", chkGasto.Checked);
                    cm.Parameters.AddWithValue("@ice", decimal.Parse(txtIce.Text));
                    cm.Parameters.AddWithValue("@valorIce", decimal.Parse(txtValorIce.Text));
                    cm.Parameters.AddWithValue("@HasIva", HasIva.Checked);
                    cm.Parameters.AddWithValue("@iva", decimal.Parse(txtIva.Text));
                    cm.Parameters.AddWithValue("@imagen",bytes);
                    cm.Parameters.AddWithValue("@imagenUrl", txtReason.Text);
                    cm.Parameters.AddWithValue("@montoTotal", decimal.Parse(txtPriceA.Text)*decimal.Parse(txtIva.Text));
                    cm.Parameters.AddWithValue("@categoriaA", txtCatA.Text);
                    cm.Parameters.AddWithValue("@categoriaB", txtCatB.Text);
                    cm.Parameters.AddWithValue("@categoriaC", txtCatC.Text);
                    cm.Parameters.AddWithValue("@categoriaD", txtCatD.Text);
                    cm.Parameters.AddWithValue("@categoriaE", txtCatE.Text);
                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item Guardado con exito.", stitle);
                    Clear();
                  
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            picBrowse.Visible = false;
            picItem.Enabled = false;
            MemoryStream ms = new MemoryStream();
            picItem.Visible = true;

            byte[] bytes = ms.ToArray();
            try
            {
                if (MessageBox.Show("Estas seguro de actualizar este producto?", "Actualizar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Productos SET codigoBarras=@codigoBarras,pDesc=@pDesc,bid=@bid,cid=@cid,precio=@precio, reorder=@reorder WHERE codigo LIKE @codigo", cn);
                    cm.Parameters.AddWithValue("@nombre", txtNameProdcut.Text);
                    cm.Parameters.AddWithValue("@codigoUno", txtCodUno.Text);
                    cm.Parameters.AddWithValue("@codigoDos", txtCodDos.Text);
                    cm.Parameters.AddWithValue("@codigoTres", txtCod3.Text);
                    cm.Parameters.AddWithValue("@codigoCuatro", txtCod4.Text);
                    cm.Parameters.AddWithValue("@codigoBarras", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@precioA", decimal.Parse(txtPriceA.Text));
                    cm.Parameters.AddWithValue("@precioB", decimal.Parse(txtPriceB.Text));
                    cm.Parameters.AddWithValue("@precioC", decimal.Parse(txtPriceC.Text));
                    cm.Parameters.AddWithValue("@precioD", decimal.Parse(txtPriceD.Text));
                    cm.Parameters.AddWithValue("@descripcion", txtReason.Text);
                    cm.Parameters.AddWithValue("@unidadCaja", int.Parse(txtUnidadCaja.Text));
                    cm.Parameters.AddWithValue("@peso", decimal.Parse(txtPesoItem.Text));
                    cm.Parameters.AddWithValue("@comision", decimal.Parse(txtComision.Text));
                    cm.Parameters.AddWithValue("@descMax", decimal.Parse(txtDescMax.Text));
                    cm.Parameters.AddWithValue("@stockMax", int.Parse(txtStockMax.Text));
                    cm.Parameters.AddWithValue("@stockMin", int.Parse(txtStockMin.Text));
                    cm.Parameters.AddWithValue("@costo", decimal.Parse(txtCosto.Text));
                    cm.Parameters.AddWithValue("@unidad", int.Parse(txtUnidad.Text));
                    cm.Parameters.AddWithValue("@bId", cboBodega.SelectedValue);
                    cm.Parameters.AddWithValue("@cId", cboCategory.SelectedValue);
                    cm.Parameters.AddWithValue("@gId", cboGroup.SelectedValue);
                    cm.Parameters.AddWithValue("@mId", cboBrand.SelectedValue);
                    cm.Parameters.AddWithValue("@servicio", chckServicio.Checked);
                    cm.Parameters.AddWithValue("@aplicaSeries", chckAplicaSeries.Checked);
                    cm.Parameters.AddWithValue("@negativo", chckNegativo.Checked);
                    cm.Parameters.AddWithValue("@combo", chckCombo.Checked);
                    cm.Parameters.AddWithValue("@gasto", chkGasto.Checked);
                    cm.Parameters.AddWithValue("@ice", decimal.Parse(txtIce.Text));
                    cm.Parameters.AddWithValue("@valorIce", decimal.Parse(txtValorIce.Text));
                    cm.Parameters.AddWithValue("@HasIva", HasIva.Checked);
                    cm.Parameters.AddWithValue("@iva", decimal.Parse(txtIva.Text));
                    cm.Parameters.AddWithValue("@imagen", bytes);
                    cm.Parameters.AddWithValue("@imagenUrl", txtReason.Text);
                    cm.Parameters.AddWithValue("@montoTotal", decimal.Parse(txtPriceA.Text) * decimal.Parse(txtIva.Text));
                    cm.Parameters.AddWithValue("@categoriaA", txtCatA.Text);
                    cm.Parameters.AddWithValue("@categoriaB", txtCatB.Text);
                    cm.Parameters.AddWithValue("@categoriaC", txtCatC.Text);
                    cm.Parameters.AddWithValue("@categoriaD", txtCatD.Text);
                    cm.Parameters.AddWithValue("@categoriaE", txtCatE.Text);

                    cn.Open();
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Item ingresado con exito.", stitle);
                    Clear();
                    this.Dispose();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ProductModule_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void ProductModule_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Group module = new Group();
            module.ShowDialog();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Brand brand = new Brand();
            brand.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Category category = new Category();
            category.ShowDialog();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Bodega bodega = new Bodega();
            bodega.ShowDialog();
        }

        private void cboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtPriceA_TextChanged(object sender, EventArgs e)
        {

        }

        private void picBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "seleciona la imagen (*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picItem.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
