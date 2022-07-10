
using POSalesDb;
using POSalesDB;
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
                            categoriasA = txtCatA.Text,
                            categoriasB = txtCatB.Text,
                            categoriasC = txtCatC.Text,
                            categoriasD = txtCatD.Text,
                            categoriasE = txtCatE.Text
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
            Items item = new Items();
            picBrowse.Visible = false;
            picItem.Enabled = false;
            MemoryStream ms = new MemoryStream();
            picItem.Visible = true;

         
            byte[] bytes = ms.ToArray();
            try
            {
                if (MessageBox.Show("Estas seguro de actualizar este Item?", "Actualizar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    decimal PrecioA = 0, PrecioB = 0, PrecioC = 0, PrecioD = 0;
                    item.nombre = txtNameProdcut.Text;
                    item.codigoUno = txtCodUno.Text;
                    item.codigoDos = txtCodDos.Text;
                    item.codigoTres = txtCod3.Text;
                    item.codigoCuatro = txtCod4.Text;
                    item.codigoBarras = txtCod3.Text;
                    item.codigoCuatro = txtCod4.Text;
                    decimal.TryParse(txtPriceA.Text, out PrecioA);
                    item.precioA = PrecioA;
                    decimal.TryParse(txtPriceB.Text, out PrecioB);
                    item.precioB = PrecioB;
                    decimal.TryParse(txtPriceC.Text, out PrecioC);
                    item.precioC = PrecioC;
                    decimal.TryParse(txtPriceD.Text, out PrecioD);
                    item.precioD = PrecioD;
                    item.descripcion= txtReason.Text;
                    item.unidadCaja= int.Parse(txtUnidadCaja.Text);
                    item.peso= decimal.Parse(txtPesoItem.Text);
                    item.comision= decimal.Parse(txtComision.Text);
                    item.descMax= decimal.Parse(txtDescMax.Text);
                    item.stockMax= int.Parse(txtStockMax.Text);
                    item.stockMin= int.Parse(txtStockMin.Text);
                    item.costo= decimal.Parse(txtCosto.Text);
                    item.unidad= int.Parse(txtUnidad.Text);
                    item.bId= cboBodega.SelectedIndex;
                    item.cId= cboCategory.SelectedIndex;
                    item.gId= cboGroup.SelectedIndex;
                    item.mId= cboBrand.SelectedIndex;
                    item.servicio= chckServicio.Checked;
                    item.aplicaSeries= chckAplicaSeries.Checked;
                    item.negativo= chckNegativo.Checked;
                    item.combo= chckCombo.Checked;
                    item.gasto= chkGasto.Checked;
                    item.ice= decimal.Parse(txtIce.Text);
                    item.valorIce= decimal.Parse(txtValorIce.Text);
                    item.HasIva= HasIva.Checked;
                    item.iva= decimal.Parse(txtIva.Text);
                    item.imagen= bytes;
                    item.imagenUrl= txtReason.Text;
                    item.montoTotal= decimal.Parse(txtPriceA.Text) * decimal.Parse(txtIva.Text);
                    item.categoriasA= txtCatA.Text;
                    item.categoriasB = txtCatB.Text;
                    item.categoriasC = txtCatC.Text;
                    item.categoriasD = txtCatD.Text;
                    item.categoriasE = txtCatE.Text;
                    DBConnect db = new DBConnect();
                   string Error = db.ActualizarItem(item);
                    if (string.IsNullOrEmpty(Error))
                    {
                        MessageBox.Show("Item ingresado con exito.", stitle);
                    }
                    else 
                    {
                        MessageBox.Show(Error);
                    }
                   
                    Clear();
                   
                   
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

        private void txtPriceA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(','))
            {
                e.KeyChar = ',';
            }
            else if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPriceB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(','))
            {
                e.KeyChar = ',';
            }
            else if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPriceC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPriceC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(','))
            {
                e.KeyChar = ',';
            }
            else if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtPriceD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(','))
            {
                e.KeyChar = ',';
            }
            else if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIva_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(','))
            {
                e.KeyChar = ',';
            }
            else if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtIce_KeyPress(object sender, KeyPressEventArgs e)
        {
               if(Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else if (e.KeyChar == '.' && !((TextBox)sender).Text.Contains(','))
            {
                e.KeyChar = ',';
            }
            else if (e.KeyChar == ',' && !((TextBox)sender).Text.Contains(','))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtStockMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                // Allow Digits and BackSpace char
            }
            else
            {
                e.Handled = true;
            }
        }

        private void HasIva_CheckedChanged(object sender, EventArgs e)
        {
            if (HasIva.Checked)
            {
                txtIva.Enabled = true;
                
            }
            else
            {
                txtIva.Enabled = false;
                txtIva.Text = "00,00";
            }
        }
    }
}
