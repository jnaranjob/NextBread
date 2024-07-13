namespace ProyectoProgramacionIII.Forms.MenuPrincipal
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.strMenu = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inicarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agrgarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProveedorPorIDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProduToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaRegistradoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCercaDeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.strMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // strMenu
            // 
            this.strMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.strMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.inventariosToolStripMenuItem,
            this.facturaciónToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem,
            this.aCercaDeToolStripMenuItem});
            this.strMenu.Location = new System.Drawing.Point(0, 0);
            this.strMenu.Name = "strMenu";
            this.strMenu.Size = new System.Drawing.Size(1211, 28);
            this.strMenu.TabIndex = 0;
            this.strMenu.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarUsuariosToolStripMenuItem,
            this.inicarSesiónToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // registrarUsuariosToolStripMenuItem
            // 
            this.registrarUsuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registrarUsuariosToolStripMenuItem.Image")));
            this.registrarUsuariosToolStripMenuItem.Name = "registrarUsuariosToolStripMenuItem";
            this.registrarUsuariosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrarUsuariosToolStripMenuItem.Text = "Registrar Usuarios";
            // 
            // inicarSesiónToolStripMenuItem
            // 
            this.inicarSesiónToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("inicarSesiónToolStripMenuItem.Image")));
            this.inicarSesiónToolStripMenuItem.Name = "inicarSesiónToolStripMenuItem";
            this.inicarSesiónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inicarSesiónToolStripMenuItem.Text = "Inicar Sesión";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agrgarToolStripMenuItem,
            this.listarProveedoresToolStripMenuItem,
            this.editarProveedoresToolStripMenuItem,
            this.buscarProveedorPorIDToolStripMenuItem});
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // agrgarToolStripMenuItem
            // 
            this.agrgarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agrgarToolStripMenuItem.Image")));
            this.agrgarToolStripMenuItem.Name = "agrgarToolStripMenuItem";
            this.agrgarToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.agrgarToolStripMenuItem.Text = "Agregar Proveedores";
            this.agrgarToolStripMenuItem.Click += new System.EventHandler(this.agrgarToolStripMenuItem_Click);
            // 
            // listarProveedoresToolStripMenuItem
            // 
            this.listarProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarProveedoresToolStripMenuItem.Image")));
            this.listarProveedoresToolStripMenuItem.Name = "listarProveedoresToolStripMenuItem";
            this.listarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.listarProveedoresToolStripMenuItem.Text = "Listar Proveedores";
            this.listarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.listarProveedoresToolStripMenuItem_Click);
            // 
            // editarProveedoresToolStripMenuItem
            // 
            this.editarProveedoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarProveedoresToolStripMenuItem.Image")));
            this.editarProveedoresToolStripMenuItem.Name = "editarProveedoresToolStripMenuItem";
            this.editarProveedoresToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.editarProveedoresToolStripMenuItem.Text = "Editar Proveedores";
            this.editarProveedoresToolStripMenuItem.Click += new System.EventHandler(this.editarProveedoresToolStripMenuItem_Click);
            // 
            // buscarProveedorPorIDToolStripMenuItem
            // 
            this.buscarProveedorPorIDToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarProveedorPorIDToolStripMenuItem.Image")));
            this.buscarProveedorPorIDToolStripMenuItem.Name = "buscarProveedorPorIDToolStripMenuItem";
            this.buscarProveedorPorIDToolStripMenuItem.Size = new System.Drawing.Size(253, 26);
            this.buscarProveedorPorIDToolStripMenuItem.Text = "Buscar Proveedor por ID";
            this.buscarProveedorPorIDToolStripMenuItem.Click += new System.EventHandler(this.buscarProveedorPorIDToolStripMenuItem_Click);
            // 
            // inventariosToolStripMenuItem
            // 
            this.inventariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProductosToolStripMenuItem,
            this.listarProductosToolStripMenuItem,
            this.editarProductosToolStripMenuItem,
            this.buscarProduToolStripMenuItem});
            this.inventariosToolStripMenuItem.Name = "inventariosToolStripMenuItem";
            this.inventariosToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.inventariosToolStripMenuItem.Text = "Inventario";
            // 
            // agregarProductosToolStripMenuItem
            // 
            this.agregarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("agregarProductosToolStripMenuItem.Image")));
            this.agregarProductosToolStripMenuItem.Name = "agregarProductosToolStripMenuItem";
            this.agregarProductosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.agregarProductosToolStripMenuItem.Text = "Agregar Productos";
            this.agregarProductosToolStripMenuItem.Click += new System.EventHandler(this.agregarProductosToolStripMenuItem_Click);
            // 
            // listarProductosToolStripMenuItem
            // 
            this.listarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("listarProductosToolStripMenuItem.Image")));
            this.listarProductosToolStripMenuItem.Name = "listarProductosToolStripMenuItem";
            this.listarProductosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.listarProductosToolStripMenuItem.Text = "Listar Productos";
            this.listarProductosToolStripMenuItem.Click += new System.EventHandler(this.listarProductosToolStripMenuItem_Click);
            // 
            // editarProductosToolStripMenuItem
            // 
            this.editarProductosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editarProductosToolStripMenuItem.Image")));
            this.editarProductosToolStripMenuItem.Name = "editarProductosToolStripMenuItem";
            this.editarProductosToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.editarProductosToolStripMenuItem.Text = "Editar Productos";
            this.editarProductosToolStripMenuItem.Click += new System.EventHandler(this.editarProductosToolStripMenuItem_Click);
            // 
            // buscarProduToolStripMenuItem
            // 
            this.buscarProduToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarProduToolStripMenuItem.Image")));
            this.buscarProduToolStripMenuItem.Name = "buscarProduToolStripMenuItem";
            this.buscarProduToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.buscarProduToolStripMenuItem.Text = "Buscar Productos por ID";
            // 
            // facturaciónToolStripMenuItem
            // 
            this.facturaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cajaRegistradoraToolStripMenuItem});
            this.facturaciónToolStripMenuItem.Name = "facturaciónToolStripMenuItem";
            this.facturaciónToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.facturaciónToolStripMenuItem.Text = "Facturación";
            // 
            // cajaRegistradoraToolStripMenuItem
            // 
            this.cajaRegistradoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cajaRegistradoraToolStripMenuItem.Image")));
            this.cajaRegistradoraToolStripMenuItem.Name = "cajaRegistradoraToolStripMenuItem";
            this.cajaRegistradoraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cajaRegistradoraToolStripMenuItem.Text = "Caja Registradora";
            this.cajaRegistradoraToolStripMenuItem.ToolTipText = "Abre caja registradora";
            this.cajaRegistradoraToolStripMenuItem.Click += new System.EventHandler(this.cajaRegistradoraToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeVentasToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reportesDeVentasToolStripMenuItem
            // 
            this.reportesDeVentasToolStripMenuItem.Name = "reportesDeVentasToolStripMenuItem";
            this.reportesDeVentasToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.reportesDeVentasToolStripMenuItem.Text = "Reportes de Ventas";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // permisosToolStripMenuItem
            // 
            this.permisosToolStripMenuItem.Name = "permisosToolStripMenuItem";
            this.permisosToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.permisosToolStripMenuItem.Text = "Permisos Sistema";
            // 
            // aCercaDeToolStripMenuItem
            // 
            this.aCercaDeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCercaDeToolStripMenuItem1});
            this.aCercaDeToolStripMenuItem.Name = "aCercaDeToolStripMenuItem";
            this.aCercaDeToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.aCercaDeToolStripMenuItem.Text = "Ayuda";
            this.aCercaDeToolStripMenuItem.Click += new System.EventHandler(this.aCercaDeToolStripMenuItem_Click);
            // 
            // aCercaDeToolStripMenuItem1
            // 
            this.aCercaDeToolStripMenuItem1.Name = "aCercaDeToolStripMenuItem1";
            this.aCercaDeToolStripMenuItem1.Size = new System.Drawing.Size(164, 26);
            this.aCercaDeToolStripMenuItem1.Text = "A Cerca de";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1211, 668);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 698);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.strMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.strMenu;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextBread POS";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.strMenu.ResumeLayout(false);
            this.strMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip strMenu;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agrgarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cajaRegistradoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem aCercaDeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProduToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProveedorPorIDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentasToolStripMenuItem;
    }
}