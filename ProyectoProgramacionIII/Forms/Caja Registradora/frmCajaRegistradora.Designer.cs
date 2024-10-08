﻿namespace ProyectoProgramacionIII.Forms.Caja_Registradora
{
    partial class frmCajaRegistradora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCajaRegistradora));
            this.grpFacturar = new System.Windows.Forms.GroupBox();
            this.dtpFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpDetalle = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.dtgLineasfactura = new System.Windows.Forms.DataGridView();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCodigoproducto = new System.Windows.Forms.TextBox();
            this.lblCodigoproducto = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTipoopago = new System.Windows.Forms.ComboBox();
            this.lblTipopago = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblIDdetalle = new System.Windows.Forms.Label();
            this.txtIDdetalle = new System.Windows.Forms.TextBox();
            this.toolAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.grpFacturar.SuspendLayout();
            this.grpDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLineasfactura)).BeginInit();
            this.SuspendLayout();
            // 
            // grpFacturar
            // 
            this.grpFacturar.BackColor = System.Drawing.Color.Transparent;
            this.grpFacturar.Controls.Add(this.dtpFechaCompra);
            this.grpFacturar.Controls.Add(this.label2);
            this.grpFacturar.Controls.Add(this.txtCodigoVenta);
            this.grpFacturar.Controls.Add(this.label1);
            this.grpFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFacturar.Location = new System.Drawing.Point(24, 18);
            this.grpFacturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFacturar.Name = "grpFacturar";
            this.grpFacturar.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpFacturar.Size = new System.Drawing.Size(619, 149);
            this.grpFacturar.TabIndex = 0;
            this.grpFacturar.TabStop = false;
            this.grpFacturar.Text = "Encabezado Factura:";
            // 
            // dtpFechaCompra
            // 
            this.dtpFechaCompra.Enabled = false;
            this.dtpFechaCompra.Location = new System.Drawing.Point(146, 86);
            this.dtpFechaCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFechaCompra.Name = "dtpFechaCompra";
            this.dtpFechaCompra.Size = new System.Drawing.Size(314, 26);
            this.dtpFechaCompra.TabIndex = 3;
            this.toolAyuda.SetToolTip(this.dtpFechaCompra, "Fecha Actual");
            this.dtpFechaCompra.ValueChanged += new System.EventHandler(this.dtpFechaCompra_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // txtCodigoVenta
            // 
            this.txtCodigoVenta.Enabled = false;
            this.txtCodigoVenta.Location = new System.Drawing.Point(146, 39);
            this.txtCodigoVenta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoVenta.Name = "txtCodigoVenta";
            this.txtCodigoVenta.Size = new System.Drawing.Size(441, 26);
            this.txtCodigoVenta.TabIndex = 1;
            this.toolAyuda.SetToolTip(this.txtCodigoVenta, "Codigo de venta");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Venta :";
            // 
            // grpDetalle
            // 
            this.grpDetalle.BackColor = System.Drawing.Color.Transparent;
            this.grpDetalle.Controls.Add(this.txtTotal);
            this.grpDetalle.Controls.Add(this.lblTotal);
            this.grpDetalle.Controls.Add(this.txtSubtotal);
            this.grpDetalle.Controls.Add(this.label5);
            this.grpDetalle.Controls.Add(this.btnCancelar);
            this.grpDetalle.Controls.Add(this.btnEliminarP);
            this.grpDetalle.Controls.Add(this.btnFacturar);
            this.grpDetalle.Controls.Add(this.dtgLineasfactura);
            this.grpDetalle.Controls.Add(this.txtPrecio);
            this.grpDetalle.Controls.Add(this.lblPrecio);
            this.grpDetalle.Controls.Add(this.txtCantidad);
            this.grpDetalle.Controls.Add(this.lblCantidad);
            this.grpDetalle.Controls.Add(this.txtCodigoproducto);
            this.grpDetalle.Controls.Add(this.lblCodigoproducto);
            this.grpDetalle.Controls.Add(this.txtDescripcion);
            this.grpDetalle.Controls.Add(this.label3);
            this.grpDetalle.Controls.Add(this.cboTipoopago);
            this.grpDetalle.Controls.Add(this.lblTipopago);
            this.grpDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDetalle.Location = new System.Drawing.Point(24, 181);
            this.grpDetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetalle.Name = "grpDetalle";
            this.grpDetalle.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpDetalle.Size = new System.Drawing.Size(619, 397);
            this.grpDetalle.TabIndex = 1;
            this.grpDetalle.TabStop = false;
            this.grpDetalle.Text = "Detalle de Factura";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(450, 288);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(138, 26);
            this.txtTotal.TabIndex = 17;
            this.toolAyuda.SetToolTip(this.txtTotal, "Total a Pagar");
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(326, 288);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 20);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total a Pagar: ";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(161, 284);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(138, 26);
            this.txtSubtotal.TabIndex = 15;
            this.toolAyuda.SetToolTip(this.txtSubtotal, "Sub-total a pagar");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 288);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Sub Total:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(163, 324);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(56, 58);
            this.btnCancelar.TabIndex = 13;
            this.toolAyuda.SetToolTip(this.btnCancelar, "Cancela la Factura.");
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarP.Image")));
            this.btnEliminarP.Location = new System.Drawing.Point(92, 324);
            this.btnEliminarP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(56, 58);
            this.btnEliminarP.TabIndex = 12;
            this.toolAyuda.SetToolTip(this.btnEliminarP, "Eliminar Productos.");
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturar.Image")));
            this.btnFacturar.Location = new System.Drawing.Point(21, 324);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(56, 58);
            this.btnFacturar.TabIndex = 11;
            this.toolAyuda.SetToolTip(this.btnFacturar, "Facturar");
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // dtgLineasfactura
            // 
            this.dtgLineasfactura.BackgroundColor = System.Drawing.Color.White;
            this.dtgLineasfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLineasfactura.Location = new System.Drawing.Point(17, 155);
            this.dtgLineasfactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgLineasfactura.Name = "dtgLineasfactura";
            this.dtgLineasfactura.RowHeadersWidth = 51;
            this.dtgLineasfactura.RowTemplate.Height = 24;
            this.dtgLineasfactura.Size = new System.Drawing.Size(569, 122);
            this.dtgLineasfactura.TabIndex = 10;
            this.toolAyuda.SetToolTip(this.dtgLineasfactura, "Lista de productos");
            this.dtgLineasfactura.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgLineasfactura_CellValueChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(161, 117);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(138, 26);
            this.txtPrecio.TabIndex = 9;
            this.toolAyuda.SetToolTip(this.txtPrecio, "Ingrese Precio de producto");
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(14, 111);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(64, 20);
            this.lblPrecio.TabIndex = 8;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(429, 111);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(158, 26);
            this.txtCantidad.TabIndex = 7;
            this.toolAyuda.SetToolTip(this.txtCantidad, "Ingrese la cantidad a comprar");
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(326, 114);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(86, 20);
            this.lblCantidad.TabIndex = 6;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtCodigoproducto
            // 
            this.txtCodigoproducto.Location = new System.Drawing.Point(161, 79);
            this.txtCodigoproducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoproducto.Name = "txtCodigoproducto";
            this.txtCodigoproducto.Size = new System.Drawing.Size(426, 26);
            this.txtCodigoproducto.TabIndex = 5;
            this.toolAyuda.SetToolTip(this.txtCodigoproducto, "Ingrese el Codigo del producto");
            this.txtCodigoproducto.TextChanged += new System.EventHandler(this.txtCodigoproducto_TextChanged);
            // 
            // lblCodigoproducto
            // 
            this.lblCodigoproducto.AutoSize = true;
            this.lblCodigoproducto.Location = new System.Drawing.Point(14, 79);
            this.lblCodigoproducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigoproducto.Name = "lblCodigoproducto";
            this.lblCodigoproducto.Size = new System.Drawing.Size(147, 20);
            this.lblCodigoproducto.TabIndex = 4;
            this.lblCodigoproducto.Text = "Codigo Producto:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(429, 38);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(158, 26);
            this.txtDescripcion.TabIndex = 3;
            this.toolAyuda.SetToolTip(this.txtDescripcion, "Decripcion de tipo de pago");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripción:";
            // 
            // cboTipoopago
            // 
            this.cboTipoopago.FormattingEnabled = true;
            this.cboTipoopago.Items.AddRange(new object[] {
            "01 - Efectivo",
            "02 - Tarjeta",
            "03 - Sinpe Movil",
            "04 - Otro"});
            this.cboTipoopago.Location = new System.Drawing.Point(161, 36);
            this.cboTipoopago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboTipoopago.Name = "cboTipoopago";
            this.cboTipoopago.Size = new System.Drawing.Size(138, 28);
            this.cboTipoopago.TabIndex = 1;
            this.toolAyuda.SetToolTip(this.cboTipoopago, "Ingrese el tipo de pago");
            this.cboTipoopago.SelectedIndexChanged += new System.EventHandler(this.cboTipoopago_SelectedIndexChanged);
            // 
            // lblTipopago
            // 
            this.lblTipopago.AutoSize = true;
            this.lblTipopago.Location = new System.Drawing.Point(14, 38);
            this.lblTipopago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipopago.Name = "lblTipopago";
            this.lblTipopago.Size = new System.Drawing.Size(94, 20);
            this.lblTipopago.TabIndex = 0;
            this.lblTipopago.Text = "Tipo Pago:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(503, 583);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Nombre Usuario:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(590, 583);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtUsuario.TabIndex = 3;
            this.txtUsuario.Text = "1";
            // 
            // lblIDdetalle
            // 
            this.lblIDdetalle.AutoSize = true;
            this.lblIDdetalle.ForeColor = System.Drawing.Color.Black;
            this.lblIDdetalle.Location = new System.Drawing.Point(408, 586);
            this.lblIDdetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIDdetalle.Name = "lblIDdetalle";
            this.lblIDdetalle.Size = new System.Drawing.Size(57, 13);
            this.lblIDdetalle.TabIndex = 4;
            this.lblIDdetalle.Text = "ID Detalle:";
            // 
            // txtIDdetalle
            // 
            this.txtIDdetalle.Location = new System.Drawing.Point(464, 583);
            this.txtIDdetalle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIDdetalle.Name = "txtIDdetalle";
            this.txtIDdetalle.Size = new System.Drawing.Size(34, 20);
            this.txtIDdetalle.TabIndex = 5;
            this.txtIDdetalle.Visible = false;
            // 
            // frmCajaRegistradora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(674, 606);
            this.Controls.Add(this.txtIDdetalle);
            this.Controls.Add(this.lblIDdetalle);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grpDetalle);
            this.Controls.Add(this.grpFacturar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "frmCajaRegistradora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Caja Registradora -- Facturación";
            this.Load += new System.EventHandler(this.frmCajaRegistradora_Load);
            this.grpFacturar.ResumeLayout(false);
            this.grpFacturar.PerformLayout();
            this.grpDetalle.ResumeLayout(false);
            this.grpDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLineasfactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFacturar;
        private System.Windows.Forms.TextBox txtCodigoVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaCompra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpDetalle;
        private System.Windows.Forms.Label lblTipopago;
        private System.Windows.Forms.ComboBox cboTipoopago;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblIDdetalle;
        private System.Windows.Forms.TextBox txtIDdetalle;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCodigoproducto;
        private System.Windows.Forms.Label lblCodigoproducto;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.DataGridView dtgLineasfactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.ToolTip toolAyuda;
    }
}