namespace ProyectoProgramacionIII.Forms.Proveedores
{
    partial class frmListarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarProveedores));
            this.grpListarProveedor = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnInactivar = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.dgvListaProveedores = new System.Windows.Forms.DataGridView();
            this.toolAyuda = new System.Windows.Forms.ToolTip(this.components);
            this.grpListarProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpListarProveedor
            // 
            this.grpListarProveedor.BackColor = System.Drawing.Color.Transparent;
            this.grpListarProveedor.Controls.Add(this.btnSalir);
            this.grpListarProveedor.Controls.Add(this.btnInactivar);
            this.grpListarProveedor.Controls.Add(this.btnEliminarProveedor);
            this.grpListarProveedor.Controls.Add(this.dgvListaProveedores);
            this.grpListarProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpListarProveedor.Location = new System.Drawing.Point(41, 26);
            this.grpListarProveedor.Name = "grpListarProveedor";
            this.grpListarProveedor.Size = new System.Drawing.Size(756, 464);
            this.grpListarProveedor.TabIndex = 0;
            this.grpListarProveedor.TabStop = false;
            this.grpListarProveedor.Text = "Listado de Proveedores:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(418, 371);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 71);
            this.btnSalir.TabIndex = 3;
            this.toolAyuda.SetToolTip(this.btnSalir, "Salir.");
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnInactivar
            // 
            this.btnInactivar.Image = ((System.Drawing.Image)(resources.GetObject("btnInactivar.Image")));
            this.btnInactivar.Location = new System.Drawing.Point(327, 371);
            this.btnInactivar.Name = "btnInactivar";
            this.btnInactivar.Size = new System.Drawing.Size(75, 71);
            this.btnInactivar.TabIndex = 2;
            this.toolAyuda.SetToolTip(this.btnInactivar, "Inactiva un proveedor.");
            this.btnInactivar.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProveedor.Image")));
            this.btnEliminarProveedor.Location = new System.Drawing.Point(233, 371);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(75, 71);
            this.btnEliminarProveedor.TabIndex = 1;
            this.toolAyuda.SetToolTip(this.btnEliminarProveedor, "Elimina un proveedor");
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // dgvListaProveedores
            // 
            this.dgvListaProveedores.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvListaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProveedores.Location = new System.Drawing.Point(22, 46);
            this.dgvListaProveedores.Name = "dgvListaProveedores";
            this.dgvListaProveedores.RowHeadersWidth = 51;
            this.dgvListaProveedores.RowTemplate.Height = 24;
            this.dgvListaProveedores.Size = new System.Drawing.Size(702, 293);
            this.dgvListaProveedores.TabIndex = 0;
            this.toolAyuda.SetToolTip(this.dgvListaProveedores, "Muestra los proveedores");
            // 
            // frmListarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(834, 524);
            this.Controls.Add(this.grpListarProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar Proveedores";
            this.grpListarProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpListarProveedor;
        private System.Windows.Forms.DataGridView dgvListaProveedores;
        private System.Windows.Forms.Button btnInactivar;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolTip toolAyuda;
    }
}