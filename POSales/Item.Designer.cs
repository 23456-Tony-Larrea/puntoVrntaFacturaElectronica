
namespace POSales
{
    partial class Item
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Item));
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoUno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoCuatro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoBarras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadCaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicio = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.aplicaSeries = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.negativo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.combo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.gasto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorIce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.imagenUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.montoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasIva = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeight = 30;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Id,
            this.codigoUno,
            this.codigoDos,
            this.codigoTres,
            this.codigoCuatro,
            this.codigoBarras,
            this.precioA,
            this.precioB,
            this.precioC,
            this.precioD,
            this.descripcion,
            this.unidadCaja,
            this.peso,
            this.comision,
            this.descMax,
            this.stockMin,
            this.stockMax,
            this.costo,
            this.unidad,
            this.bodega,
            this.categoria,
            this.grupo,
            this.marca,
            this.servicio,
            this.aplicaSeries,
            this.negativo,
            this.combo,
            this.gasto,
            this.ice,
            this.valorIce,
            this.imagen,
            this.imagenUrl,
            this.iva,
            this.montoTotal,
            this.HasIva});
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(0, 0);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersVisible = false;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(984, 481);
            this.dgvProduct.TabIndex = 3;
            this.dgvProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 80);
            this.panel1.TabIndex = 2;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = ((System.Drawing.Image)(resources.GetObject("txtSearch.Icon")));
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(316, 26);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search here";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(376, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search here";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(930, 26);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(39, 32);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Product";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.Name = "No";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            // 
            // codigoUno
            // 
            this.codigoUno.HeaderText = "codigoUno";
            this.codigoUno.Name = "codigoUno";
            // 
            // codigoDos
            // 
            this.codigoDos.HeaderText = "codigoDos";
            this.codigoDos.Name = "codigoDos";
            // 
            // codigoTres
            // 
            this.codigoTres.HeaderText = "codigoTres";
            this.codigoTres.Name = "codigoTres";
            // 
            // codigoCuatro
            // 
            this.codigoCuatro.HeaderText = "codigoCuatro";
            this.codigoCuatro.Name = "codigoCuatro";
            // 
            // codigoBarras
            // 
            this.codigoBarras.HeaderText = "codigoBarras";
            this.codigoBarras.Name = "codigoBarras";
            // 
            // precioA
            // 
            this.precioA.HeaderText = "precioA";
            this.precioA.Name = "precioA";
            // 
            // precioB
            // 
            this.precioB.HeaderText = "precioB";
            this.precioB.Name = "precioB";
            // 
            // precioC
            // 
            this.precioC.HeaderText = "precioC";
            this.precioC.Name = "precioC";
            // 
            // precioD
            // 
            this.precioD.HeaderText = "precioD";
            this.precioD.Name = "precioD";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // unidadCaja
            // 
            this.unidadCaja.HeaderText = "unidadCaja";
            this.unidadCaja.Name = "unidadCaja";
            // 
            // peso
            // 
            this.peso.HeaderText = "peso";
            this.peso.Name = "peso";
            // 
            // comision
            // 
            this.comision.HeaderText = "comision";
            this.comision.Name = "comision";
            // 
            // descMax
            // 
            this.descMax.HeaderText = "descMax";
            this.descMax.Name = "descMax";
            // 
            // stockMin
            // 
            this.stockMin.HeaderText = "stockMin";
            this.stockMin.Name = "stockMin";
            // 
            // stockMax
            // 
            this.stockMax.HeaderText = "stockMax";
            this.stockMax.Name = "stockMax";
            // 
            // costo
            // 
            this.costo.HeaderText = "costo";
            this.costo.Name = "costo";
            // 
            // unidad
            // 
            this.unidad.HeaderText = "unidad";
            this.unidad.Name = "unidad";
            // 
            // bodega
            // 
            this.bodega.HeaderText = "Column1";
            this.bodega.Name = "bodega";
            // 
            // categoria
            // 
            this.categoria.HeaderText = "categoria";
            this.categoria.Name = "categoria";
            // 
            // grupo
            // 
            this.grupo.HeaderText = "grupo";
            this.grupo.Name = "grupo";
            // 
            // marca
            // 
            this.marca.HeaderText = "marca";
            this.marca.Name = "marca";
            // 
            // servicio
            // 
            this.servicio.HeaderText = "servicio";
            this.servicio.Name = "servicio";
            // 
            // aplicaSeries
            // 
            this.aplicaSeries.HeaderText = "aplicaSeries";
            this.aplicaSeries.Name = "aplicaSeries";
            // 
            // negativo
            // 
            this.negativo.HeaderText = "negativo";
            this.negativo.Name = "negativo";
            // 
            // combo
            // 
            this.combo.HeaderText = "combo";
            this.combo.Name = "combo";
            // 
            // gasto
            // 
            this.gasto.HeaderText = "gasto";
            this.gasto.Name = "gasto";
            // 
            // ice
            // 
            this.ice.HeaderText = "ice";
            this.ice.Name = "ice";
            // 
            // valorIce
            // 
            this.valorIce.HeaderText = "valorIce";
            this.valorIce.Name = "valorIce";
            // 
            // imagen
            // 
            this.imagen.HeaderText = "imagen";
            this.imagen.Name = "imagen";
            // 
            // imagenUrl
            // 
            this.imagenUrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.imagenUrl.HeaderText = "imagenUrl";
            this.imagenUrl.Name = "imagenUrl";
            this.imagenUrl.Visible = false;
            // 
            // iva
            // 
            this.iva.HeaderText = "iva";
            this.iva.Name = "iva";
            // 
            // montoTotal
            // 
            this.montoTotal.HeaderText = "montoTotal";
            this.montoTotal.Name = "montoTotal";
            // 
            // HasIva
            // 
            this.HasIva.HeaderText = "HasIva";
            this.HasIva.Name = "HasIva";
            // 
            // Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.ControlBox = false;
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Item";
            this.Text = "PRODUCT";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoUno;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTres;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoCuatro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoBarras;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioA;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioB;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioC;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioD;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadCaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn peso;
        private System.Windows.Forms.DataGridViewTextBoxColumn comision;
        private System.Windows.Forms.DataGridViewTextBoxColumn descMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn marca;
        private System.Windows.Forms.DataGridViewCheckBoxColumn servicio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aplicaSeries;
        private System.Windows.Forms.DataGridViewCheckBoxColumn negativo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn combo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gasto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ice;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorIce;
        private System.Windows.Forms.DataGridViewImageColumn imagen;
        private System.Windows.Forms.DataGridViewTextBoxColumn imagenUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn montoTotal;
        private System.Windows.Forms.DataGridViewCheckBoxColumn HasIva;
    }
}