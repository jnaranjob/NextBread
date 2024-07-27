namespace ProyectoProgramacionIII.Forms.Inventario
{
    partial class frmInventario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.toolAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.btnAgregarP = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.grpInventario = new System.Windows.Forms.GroupBox();
            this.txtPrecio = new System.Windows.Forms.MaskedTextBox();
            this.lblIDProvedor = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarP.Image")));
            this.btnAgregarP.Location = new System.Drawing.Point(188, 296);
            this.btnAgregarP.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(56, 58);
            this.btnAgregarP.TabIndex = 13;
            this.toolAyuda.SetToolTip(this.btnAgregarP, "Agrega un Nuevo Producto al Inventario.");
            this.btnAgregarP.UseVisualStyleBackColor = true;
            this.btnAgregarP.Click += new System.EventHandler(this.btnAgregarP_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(312, 296);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 58);
            this.btnSalir.TabIndex = 15;
            this.toolAyuda.SetToolTip(this.btnSalir, "Salir.");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(249, 296);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 58);
            this.btnCancelar.TabIndex = 14;
            this.toolAyuda.SetToolTip(this.btnCancelar, "Cancela la Operación ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(338, 259);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(79, 28);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.toolAyuda.SetToolTip(this.btnBuscar, "Busca un proveedor");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Enabled = false;
            this.txtIDProveedor.Location = new System.Drawing.Point(188, 261);
            this.txtIDProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(136, 26);
            this.txtIDProveedor.TabIndex = 11;
            this.toolAyuda.SetToolTip(this.txtIDProveedor, "ID Proveedor");
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(188, 214);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(76, 26);
            this.txtCantidad.TabIndex = 9;
            this.toolAyuda.SetToolTip(this.txtCantidad, "Ingrese la cantidad del producto");
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(188, 123);
            this.cboEstado.Margin = new System.Windows.Forms.Padding(2);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(136, 28);
            this.cboEstado.TabIndex = 5;
            this.toolAyuda.SetToolTip(this.cboEstado, "Ingrese el estado");
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(188, 83);
            this.txtNombreP.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(219, 26);
            this.txtNombreP.TabIndex = 3;
            this.toolAyuda.SetToolTip(this.txtNombreP, "Ingrese el nombre del producto");
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(188, 40);
            this.txtCodigoP.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(219, 26);
            this.txtCodigoP.TabIndex = 1;
            this.toolAyuda.SetToolTip(this.txtCodigoP, "Codigo del Producto");
            // 
            // grpInventario
            // 
            this.grpInventario.BackColor = System.Drawing.Color.Transparent;
            this.grpInventario.Controls.Add(this.txtPrecio);
            this.grpInventario.Controls.Add(this.btnSalir);
            this.grpInventario.Controls.Add(this.btnCancelar);
            this.grpInventario.Controls.Add(this.btnAgregarP);
            this.grpInventario.Controls.Add(this.btnBuscar);
            this.grpInventario.Controls.Add(this.txtIDProveedor);
            this.grpInventario.Controls.Add(this.lblIDProvedor);
            this.grpInventario.Controls.Add(this.txtCantidad);
            this.grpInventario.Controls.Add(this.lblCantidad);
            this.grpInventario.Controls.Add(this.lblPrecio);
            this.grpInventario.Controls.Add(this.cboEstado);
            this.grpInventario.Controls.Add(this.lblEstado);
            this.grpInventario.Controls.Add(this.txtNombreP);
            this.grpInventario.Controls.Add(this.label1);
            this.grpInventario.Controls.Add(this.txtCodigoP);
            this.grpInventario.Controls.Add(this.lblCodigoP);
            this.grpInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInventario.Location = new System.Drawing.Point(37, 26);
            this.grpInventario.Margin = new System.Windows.Forms.Padding(2);
            this.grpInventario.Name = "grpInventario";
            this.grpInventario.Padding = new System.Windows.Forms.Padding(2);
            this.grpInventario.Size = new System.Drawing.Size(524, 371);
            this.grpInventario.TabIndex = 0;
            this.grpInventario.TabStop = false;
            this.grpInventario.Text = "Inventario:";
            this.grpInventario.Enter += new System.EventHandler(this.grpInventario_Enter);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(188, 169);
            this.txtPrecio.Mask = "₡ 000000";
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 26);
            this.txtPrecio.TabIndex = 16;
            this.txtPrecio.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtPrecio_MaskInputRejected);
            // 
            // lblIDProvedor
            // 
            this.lblIDProvedor.AutoSize = true;
            this.lblIDProvedor.Location = new System.Drawing.Point(27, 259);
            this.lblIDProvedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDProvedor.Name = "lblIDProvedor";
            this.lblIDProvedor.Size = new System.Drawing.Size(119, 20);
            this.lblIDProvedor.TabIndex = 10;
            this.lblIDProvedor.Text = "ID Proveedor:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 214);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 20);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(27, 169);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 20);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(27, 125);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Producto:";
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Location = new System.Drawing.Point(27, 40);
            this.lblCodigoP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(147, 20);
            this.lblCodigoP.TabIndex = 0;
            this.lblCodigoP.Text = "Codigo Producto:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(410, 415);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(86, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nombre Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(496, 413);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 436);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grpInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.grpInventario.ResumeLayout(false);
            this.grpInventario.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolAyuda;
        private System.Windows.Forms.GroupBox grpInventario;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label lblCodigoP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAgregarP;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label lblIDProvedor;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.MaskedTextBox txtPrecio;
    }
}