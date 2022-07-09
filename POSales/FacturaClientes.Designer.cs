namespace POSales
{
    partial class FacturaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturaClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LinFac = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.ggvProductos = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtMontoPago = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnGuardarP = new System.Windows.Forms.Button();
            this.btnImpirmir = new System.Windows.Forms.Button();
            this.cboRegistrado = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ggvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 95);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modulo Facturas";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(205, 100);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(158, 28);
            this.txtCodigo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Codigo de la factura";
            // 
            // LinFac
            // 
            this.LinFac.AutoSize = true;
            this.LinFac.LinkColor = System.Drawing.Color.Silver;
            this.LinFac.Location = new System.Drawing.Point(370, 108);
            this.LinFac.Name = "LinFac";
            this.LinFac.Size = new System.Drawing.Size(86, 19);
            this.LinFac.TabIndex = 8;
            this.LinFac.TabStop = true;
            this.LinFac.Text = "[Generar]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cliente";
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(110, 158);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(395, 27);
            this.cboClientes.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Registrado por";
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(159, 274);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(346, 27);
            this.cboProductos.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 337);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "Cantidad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(332, 337);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "total";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(3, 368);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 28);
            this.txtPrice.TabIndex = 19;
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(148, 368);
            this.txtCant.Name = "txtCant";
            this.txtCant.Size = new System.Drawing.Size(100, 28);
            this.txtCant.TabIndex = 20;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(311, 368);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 28);
            this.txtTotal.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(491, 350);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(133, 46);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar producto";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(491, 402);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(133, 46);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar producto";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // ggvProductos
            // 
            this.ggvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ggvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Id,
            this.Producto,
            this.precio,
            this.cantidad,
            this.total});
            this.ggvProductos.Location = new System.Drawing.Point(0, 454);
            this.ggvProductos.Name = "ggvProductos";
            this.ggvProductos.RowHeadersWidth = 51;
            this.ggvProductos.RowTemplate.Height = 24;
            this.ggvProductos.Size = new System.Drawing.Size(672, 192);
            this.ggvProductos.TabIndex = 24;
            // 
            // No
            // 
            this.No.HeaderText = "No";
            this.No.MinimumWidth = 6;
            this.No.Name = "No";
            this.No.Width = 125;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 125;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Productos";
            this.Producto.MinimumWidth = 6;
            this.Producto.Name = "Producto";
            this.Producto.Width = 125;
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.MinimumWidth = 6;
            this.precio.Name = "precio";
            this.precio.Width = 125;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "cantidad";
            this.cantidad.MinimumWidth = 6;
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 125;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.Width = 125;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 679);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "SubTotal";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(96, 676);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 28);
            this.txtSubtotal.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(203, 679);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Descuento";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(307, 676);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 28);
            this.txtDescuento.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(440, 679);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Precio Unitario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(429, 734);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Monto de pago";
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(572, 670);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(100, 28);
            this.txtUnit.TabIndex = 31;
            // 
            // txtMontoPago
            // 
            this.txtMontoPago.Location = new System.Drawing.Point(572, 731);
            this.txtMontoPago.Name = "txtMontoPago";
            this.txtMontoPago.Size = new System.Drawing.Size(100, 28);
            this.txtMontoPago.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(429, 796);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Balance";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(572, 793);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(100, 28);
            this.balance.TabIndex = 34;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(219, 850);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(81, 28);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnGuardarP
            // 
            this.btnGuardarP.Location = new System.Drawing.Point(86, 850);
            this.btnGuardarP.Name = "btnGuardarP";
            this.btnGuardarP.Size = new System.Drawing.Size(106, 28);
            this.btnGuardarP.TabIndex = 36;
            this.btnGuardarP.Text = "Guardar";
            this.btnGuardarP.UseVisualStyleBackColor = true;
            // 
            // btnImpirmir
            // 
            this.btnImpirmir.Location = new System.Drawing.Point(326, 850);
            this.btnImpirmir.Name = "btnImpirmir";
            this.btnImpirmir.Size = new System.Drawing.Size(108, 28);
            this.btnImpirmir.TabIndex = 37;
            this.btnImpirmir.Text = "Imprimir";
            this.btnImpirmir.UseVisualStyleBackColor = true;
            // 
            // cboRegistrado
            // 
            this.cboRegistrado.FormattingEnabled = true;
            this.cboRegistrado.Location = new System.Drawing.Point(159, 211);
            this.cboRegistrado.Name = "cboRegistrado";
            this.cboRegistrado.Size = new System.Drawing.Size(346, 27);
            this.cboRegistrado.TabIndex = 38;
            // 
            // FacturaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 884);
            this.Controls.Add(this.cboRegistrado);
            this.Controls.Add(this.btnImpirmir);
            this.Controls.Add(this.btnGuardarP);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtMontoPago);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ggvProductos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LinFac);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FacturaClientes";
            this.Text = "FacturaClientes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ggvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel LinFac;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboClientes;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProductos;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView ggvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSubtotal;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDescuento;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtMontoPago;
        public System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnGuardarP;
        private System.Windows.Forms.Button btnImpirmir;
        private System.Windows.Forms.ComboBox cboRegistrado;
    }
}