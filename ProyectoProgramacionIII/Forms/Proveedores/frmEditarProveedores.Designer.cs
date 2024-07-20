namespace ProyectoProgramacionIII.Forms.Proveedores
{
    partial class frmEditarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProveedores));
            this.tooAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtNomreP = new System.Windows.Forms.TextBox();
            this.grbBuscaProvedor = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblIDProveedor = new System.Windows.Forms.Label();
            this.grbEditaProveedor = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbBuscaProvedor.SuspendLayout();
            this.grbEditaProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(321, 41);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(192, 30);
            this.txtIDProveedor.TabIndex = 1;
            this.tooAyuda.SetToolTip(this.txtIDProveedor, "Ingrese un ID a Buscar");
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(227, 156);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 71);
            this.btnSalir.TabIndex = 5;
            this.tooAyuda.SetToolTip(this.btnSalir, "Salir.");
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(136, 156);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 71);
            this.btnEditar.TabIndex = 4;
            this.tooAyuda.SetToolTip(this.btnEditar, "Edita un Proveedor");
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "1 - Activo",
            "0 - Inactivo"});
            this.cboEstado.Location = new System.Drawing.Point(136, 99);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(166, 33);
            this.cboEstado.TabIndex = 3;
            this.tooAyuda.SetToolTip(this.cboEstado, "Estado de Proveedor");
            // 
            // txtNomreP
            // 
            this.txtNomreP.Location = new System.Drawing.Point(136, 51);
            this.txtNomreP.Name = "txtNomreP";
            this.txtNomreP.Size = new System.Drawing.Size(410, 30);
            this.txtNomreP.TabIndex = 2;
            this.tooAyuda.SetToolTip(this.txtNomreP, "Nombre del proveedor");
            // 
            // grbBuscaProvedor
            // 
            this.grbBuscaProvedor.BackColor = System.Drawing.Color.Transparent;
            this.grbBuscaProvedor.Controls.Add(this.btnBuscar);
            this.grbBuscaProvedor.Controls.Add(this.txtIDProveedor);
            this.grbBuscaProvedor.Controls.Add(this.lblIDProveedor);
            this.grbBuscaProvedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscaProvedor.Location = new System.Drawing.Point(57, 38);
            this.grbBuscaProvedor.Name = "grbBuscaProvedor";
            this.grbBuscaProvedor.Size = new System.Drawing.Size(649, 106);
            this.grbBuscaProvedor.TabIndex = 0;
            this.grbBuscaProvedor.TabStop = false;
            this.grbBuscaProvedor.Text = "Buscar Proveedor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(530, 41);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 37);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblIDProveedor
            // 
            this.lblIDProveedor.AutoSize = true;
            this.lblIDProveedor.Location = new System.Drawing.Point(21, 39);
            this.lblIDProveedor.Name = "lblIDProveedor";
            this.lblIDProveedor.Size = new System.Drawing.Size(281, 25);
            this.lblIDProveedor.TabIndex = 0;
            this.lblIDProveedor.Text = "Ingrese el ID del Proveedor:";
            // 
            // grbEditaProveedor
            // 
            this.grbEditaProveedor.BackColor = System.Drawing.Color.Transparent;
            this.grbEditaProveedor.Controls.Add(this.btnSalir);
            this.grbEditaProveedor.Controls.Add(this.btnEditar);
            this.grbEditaProveedor.Controls.Add(this.cboEstado);
            this.grbEditaProveedor.Controls.Add(this.txtNomreP);
            this.grbEditaProveedor.Controls.Add(this.label2);
            this.grbEditaProveedor.Controls.Add(this.label1);
            this.grbEditaProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditaProveedor.Location = new System.Drawing.Point(57, 164);
            this.grbEditaProveedor.Name = "grbEditaProveedor";
            this.grbEditaProveedor.Size = new System.Drawing.Size(649, 241);
            this.grbEditaProveedor.TabIndex = 1;
            this.grbEditaProveedor.TabStop = false;
            this.grbEditaProveedor.Text = "Edita Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // frmEditarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(770, 447);
            this.Controls.Add(this.grbEditaProveedor);
            this.Controls.Add(this.grbBuscaProvedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmEditarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Proveedores";
            this.Load += new System.EventHandler(this.frmEditarProveedores_Load);
            this.grbBuscaProvedor.ResumeLayout(false);
            this.grbBuscaProvedor.PerformLayout();
            this.grbEditaProveedor.ResumeLayout(false);
            this.grbEditaProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip tooAyuda;
        private System.Windows.Forms.GroupBox grbBuscaProvedor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label lblIDProveedor;
        private System.Windows.Forms.GroupBox grbEditaProveedor;
        private System.Windows.Forms.TextBox txtNomreP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ComboBox cboEstado;
    }
}