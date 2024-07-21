namespace ProyectoProgramacionIII.Forms.Proveedores
{
    partial class frmBuscarProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscarProveedor));
            this.toolAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.txtIDProveedor = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grbBuscarProveedor = new System.Windows.Forms.GroupBox();
            this.lblIDProveedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.grbBuscarProveedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDProveedor
            // 
            this.txtIDProveedor.Location = new System.Drawing.Point(323, 51);
            this.txtIDProveedor.Name = "txtIDProveedor";
            this.txtIDProveedor.Size = new System.Drawing.Size(297, 30);
            this.txtIDProveedor.TabIndex = 1;
            this.toolAyuda.SetToolTip(this.txtIDProveedor, "Ingrese un ID de Proveedor Valido.");
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(91, 274);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 71);
            this.btnBuscar.TabIndex = 2;
            this.toolAyuda.SetToolTip(this.btnBuscar, "Busca el ID de Proveedor.");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
            this.btnSeleccionar.Location = new System.Drawing.Point(188, 274);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 71);
            this.btnSeleccionar.TabIndex = 3;
            this.toolAyuda.SetToolTip(this.btnSeleccionar, "Selecciona el ID de Proveedor.");
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.BackgroundColor = System.Drawing.Color.White;
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(34, 111);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(586, 150);
            this.dgvProveedor.TabIndex = 4;
            this.toolAyuda.SetToolTip(this.dgvProveedor, "Muestra la Información del Proveedor");
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(283, 274);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 71);
            this.btnSalir.TabIndex = 5;
            this.toolAyuda.SetToolTip(this.btnSalir, "Salir.");
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // grbBuscarProveedor
            // 
            this.grbBuscarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.grbBuscarProveedor.Controls.Add(this.btnSalir);
            this.grbBuscarProveedor.Controls.Add(this.dgvProveedor);
            this.grbBuscarProveedor.Controls.Add(this.btnSeleccionar);
            this.grbBuscarProveedor.Controls.Add(this.btnBuscar);
            this.grbBuscarProveedor.Controls.Add(this.txtIDProveedor);
            this.grbBuscarProveedor.Controls.Add(this.lblIDProveedor);
            this.grbBuscarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbBuscarProveedor.Location = new System.Drawing.Point(33, 13);
            this.grbBuscarProveedor.Name = "grbBuscarProveedor";
            this.grbBuscarProveedor.Size = new System.Drawing.Size(675, 367);
            this.grbBuscarProveedor.TabIndex = 0;
            this.grbBuscarProveedor.TabStop = false;
            this.grbBuscarProveedor.Text = "Buscar Proveedor";
            // 
            // lblIDProveedor
            // 
            this.lblIDProveedor.AutoSize = true;
            this.lblIDProveedor.Location = new System.Drawing.Point(29, 49);
            this.lblIDProveedor.Name = "lblIDProveedor";
            this.lblIDProveedor.Size = new System.Drawing.Size(276, 25);
            this.lblIDProveedor.TabIndex = 0;
            this.lblIDProveedor.Text = "Ingrese el ID de Proveedor:";
            // 
            // frmBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(751, 416);
            this.Controls.Add(this.grbBuscarProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmBuscarProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca Proveedor por ID";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.grbBuscarProveedor.ResumeLayout(false);
            this.grbBuscarProveedor.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolAyuda;
        private System.Windows.Forms.GroupBox grbBuscarProveedor;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIDProveedor;
        private System.Windows.Forms.Label lblIDProveedor;
        private System.Windows.Forms.Button btnSalir;
    }
}