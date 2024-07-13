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
            this.grpInventario = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.lblIDProvedor = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtPrecioP = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.lblCodigoP = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grpInventario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarP
            // 
            this.btnAgregarP.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarP.Image")));
            this.btnAgregarP.Location = new System.Drawing.Point(251, 364);
            this.btnAgregarP.Name = "btnAgregarP";
            this.btnAgregarP.Size = new System.Drawing.Size(75, 71);
            this.btnAgregarP.TabIndex = 13;
            this.toolAyuda.SetToolTip(this.btnAgregarP, "Agrega un Nuevo Producto al Inventario.");
            this.btnAgregarP.UseVisualStyleBackColor = true;
            // 
            // grpInventario
            // 
            this.grpInventario.BackColor = System.Drawing.Color.Transparent;
            this.grpInventario.Controls.Add(this.btnSalir);
            this.grpInventario.Controls.Add(this.btnCancelar);
            this.grpInventario.Controls.Add(this.btnAgregarP);
            this.grpInventario.Controls.Add(this.btnBuscar);
            this.grpInventario.Controls.Add(this.txtIDProveedor);
            this.grpInventario.Controls.Add(this.lblIDProvedor);
            this.grpInventario.Controls.Add(this.txtCantidad);
            this.grpInventario.Controls.Add(this.lblCantidad);
            this.grpInventario.Controls.Add(this.txtPrecioP);
            this.grpInventario.Controls.Add(this.lblPrecio);
            this.grpInventario.Controls.Add(this.cboEstado);
            this.grpInventario.Controls.Add(this.lblEstado);
            this.grpInventario.Controls.Add(this.txtNombreP);
            this.grpInventario.Controls.Add(this.label1);
            this.grpInventario.Controls.Add(this.txtCodigoP);
            this.grpInventario.Controls.Add(this.lblCodigoP);
            this.grpInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInventario.Location = new System.Drawing.Point(49, 32);
            this.grpInventario.Name = "grpInventario";
            this.grpInventario.Size = new System.Drawing.Size(699, 457);
            this.grpInventario.TabIndex = 0;
            this.grpInventario.TabStop = false;
            this.grpInventario.Text = "Inventario:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(416, 364);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 71);
            this.btnSalir.TabIndex = 15;
            this.toolAyuda.SetToolTip(this.btnSalir, "Salir.");
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(332, 364);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 71);
            this.btnCancelar.TabIndex = 14;
            this.toolAyuda.SetToolTip(this.btnCancelar, "Cancela la Operación ");
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(450, 319);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(105, 34);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.Text = "Buscar";
            this.toolAyuda.SetToolTip(this.btnBuscar, "Busca un proveedor");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Enabled = false;
            this.txtIDProveedor.Location = new System.Drawing.Point(251, 321);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(180, 30);
            this.txtIDProveedor.TabIndex = 11;
            this.toolAyuda.SetToolTip(this.txtIDProveedor, "ID Proveedor");
            // 
            // lblIDProvedor
            // 
            this.lblIDProvedor.AutoSize = true;
            this.lblIDProvedor.Location = new System.Drawing.Point(36, 319);
            this.lblIDProvedor.Name = "lblIDProvedor";
            this.lblIDProvedor.Size = new System.Drawing.Size(145, 25);
            this.lblIDProvedor.TabIndex = 10;
            this.lblIDProvedor.Text = "ID Proveedor:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(251, 264);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 30);
            this.txtCantidad.TabIndex = 9;
            this.toolAyuda.SetToolTip(this.txtCantidad, "Ingrese la cantidad del producto");
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 264);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(106, 25);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecioP
            // 
            this.txtPrecioP.Location = new System.Drawing.Point(251, 208);
            this.txtPrecioP.Name = "txtPrecioP";
            this.txtPrecioP.Size = new System.Drawing.Size(149, 30);
            this.txtPrecioP.TabIndex = 7;
            this.toolAyuda.SetToolTip(this.txtPrecioP, "Ingrese el precio del producto.");
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(36, 208);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(80, 25);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio:";
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "1 - Activo",
            "0 - Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(251, 151);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(180, 33);
            this.cboEstado.TabIndex = 5;
            this.toolAyuda.SetToolTip(this.cboEstado, "Ingrese el estado");
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(36, 154);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(86, 25);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(251, 102);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(291, 30);
            this.txtNombreP.TabIndex = 3;
            this.toolAyuda.SetToolTip(this.txtNombreP, "Ingrese el nombre del producto");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre Producto:";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Location = new System.Drawing.Point(251, 49);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.Size = new System.Drawing.Size(291, 30);
            this.txtCodigoP.TabIndex = 1;
            this.toolAyuda.SetToolTip(this.txtCodigoP, "Codigo del Producto");
            // 
            // lblCodigoP
            // 
            this.lblCodigoP.AutoSize = true;
            this.lblCodigoP.Location = new System.Drawing.Point(36, 49);
            this.lblCodigoP.Name = "lblCodigoP";
            this.lblCodigoP.Size = new System.Drawing.Size(180, 25);
            this.lblCodigoP.TabIndex = 0;
            this.lblCodigoP.Text = "Codigo Producto:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(547, 511);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(109, 16);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Nombre Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(662, 508);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 22);
            this.txtUsuario.TabIndex = 2;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grpInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox txtPrecioP;
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
    }
}