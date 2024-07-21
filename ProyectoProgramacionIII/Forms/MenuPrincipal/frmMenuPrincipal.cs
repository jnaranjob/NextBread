using ProyectoProgramacionIII.Conexion;
using ProyectoProgramacionIII.Forms.Caja_Registradora;
using ProyectoProgramacionIII.Forms.Inventario;
using ProyectoProgramacionIII.Forms.Proveedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacionIII.Forms.MenuPrincipal
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.IsMdiContainer = true;
            ConexionBD dbConnection = ConexionBD.Instancia;
        }

        private void cajaRegistradoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCajaRegistradora frmCaja = new frmCajaRegistradora();
            //frmCaja.MdiParent = this;
            frmCaja.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = new System.Drawing.Size(1224, 700);
            try
            {
                // Abrir la conexión al cargar el formulario
                ConexionBD.Instancia.AbrirConexion();
                Console.WriteLine("Conexión abierta correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la conexión: " + ex.Message);
            }
        }

        private void agrgarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProveedores frmProve = new frmProveedores();
            //frmCaja.MdiParent = this;
            frmProve.Show();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInventario frmInven = new frmInventario();
            //frmCaja.MdiParent = this;
            frmInven.Show();
        }

        private void aCercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProveedores frmListProve = new frmListarProveedores();
            //frmCaja.MdiParent = this;
            frmListProve.Show();
        }

        private void listarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListarProductos frmListPro = new frmListarProductos();
            //frmCaja.MdiParent = this;
            frmListPro.Show();
        }

        private void editarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarProveedores frmEditaPro = new frmEditarProveedores();
            //frmCaja.MdiParent = this;
            frmEditaPro.Show();
        }

        private void buscarProveedorPorIDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor frmBuscaPro = new frmBuscarProveedor();
            //frmCaja.MdiParent = this;
            frmBuscaPro.Show();
        }

        private void editarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarInventario frmEditaProd = new frmEditarInventario();
            //frmCaja.MdiParent = this;
            frmEditaProd.Show();
        }
    }
}
