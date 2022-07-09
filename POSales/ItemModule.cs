
using POSalesDb;
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
            try
            {
                if (MessageBox.Show("Estas seguro de guardar este Item?", "Item Guardado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MemoryStream ms = new MemoryStream();
                    picItem.Image.Save(ms, picItem.Image.RawFormat);
                    byte[] bytes = ms.ToArray();

                    using (var repo = new Repository(cn))
                        repo.InsertItem<Items>(new Items
                        {

                            nombre = txtNameProdcut.Text,
                            codigoUno = txtCodUno.Text,
                            codigoDos = txtCodDos.Text,
                            codigoTres = txtCod3.Text,
                            codigoCuatro = txtCod4.Text,
                            codigoBarras = txtBarcode.Text,
                            precioA = decimal.Parse(txtPriceA.Text),
                            precioB = decimal.Parse(txtPriceB.Text),
                            precioC = decimal.Parse(txtPriceC.Text),
                            precioD = decimal.Parse(txtPriceD.Text),
                            descripcion = txtReason.Text,
                            unidadCaja = Int16.Parse(txtUnidadCaja.Text),
                            peso = decimal.Parse(txtPesoItem.Text),
                            comision = decimal.Parse(txtComision.Text),
                            descMax = decimal.Parse(txtDescMax.Text),
                            stockMin = Int16.Parse(txtStockMin.Text),
                            stockMax = Int16.Parse(txtStockMax.Text),
                            costo = decimal.Parse(txtCosto.Text),
                            unidad = int.Parse(txtUnidad.Text),
                            bId = Convert.ToInt16(cboBodega.SelectedValue),
                            cId = Convert.ToInt16(cboCategory.SelectedValue),
                            gId = Convert.ToInt16(cboGroup.SelectedValue),
                            mId = Convert.ToInt16(cboBrand.SelectedValue),
                            servicio = chckServicio.Checked,
                            aplicaSeries = chckAplicaSeries.Checked,
                            negativo = chckNegativo.Checked,
                            combo = chckCombo.Checked,
                            gasto = chkGasto.Checked,
                            ice = decimal.Parse(txtIce.Text),
                            valorIce = decimal.Parse(txtValorIce.Text),
                            HasIva = HasIva.Checked,
                            iva = decimal.Parse(txtIva.Text),
                            imagen = bytes,
                            imagenUrl = txtReason.Text,
                            montoTotal = decimal.Parse(valA.Text),
                            categoriaA = txtCatA.Text,
                            categoriaB = txtCatB.Text,
                            categoriaC = txtCatC.Text,
                            categoriaD = txtCatD.Text,
                            categoriaE = txtCatE.Text
                        }, new string[] { nameof(Items.Id) }); 
                    MessageBox.Show("Item registrado con exito.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Dispose();
                    product.cargarItem();
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
                if (MessageBox.Show("Estas seguro de actualizar este Item?", "Actualizar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cm = new SqlCommand("UPDATE Items SET nombre=@nombre,codigoUno=@codigoUno,codigoDos=@codigoDos,codigoTres=@codigoTres,codigoCuatro=@codigoCuatro,precioA=@precioA,precioB=@precioB,precioC=@precioC,precioD=@precioD,descripcion=@descripcion,unidadCaja=@unidadCaja,peso=@peso,comision=@comision,descMax=@descMax,stockMin=@stockMin,stockMax=@stockMax,costo=@costo,unidad=@unidad,bId=@bId,cId=@cId ,gId=@gId,mId=@mId,servicio=@servicio,aplicaSeries=@aplicaSeries,negativo=@negativo,combo=@combo,gasto=@gasto,ice=@ice,valorIce=@valorIce,imagen=@imagen,imagenUrl=@imagenUrl,iva=@iva,montoTotal=@montoTotal,HasIva=HasIva,categoriaA=@categoriaA,categoriaB=@categoriaB,categoriaC=@categoriaC,categoriaD=@categoriaD,categoriaE=@categoriaE   WHERE Id like'" + txtIdProd.Text + "'", cn);
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
                {

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
