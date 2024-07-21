using ProyectoProgramacionIII.Entidades;
using ProyectoProgramacionIII.Forms.Proveedores;
using ProyectoProgramacionIII.Interfaces;
using ProyectoProgramacionIII.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoProgramacionIII.Forms.Inventario
{
    public partial class frmInventario : Form
    {

        private IntInventario _Inventario;

        public frmInventario()
        {
            InitializeComponent();
            _Inventario = new ModuloInventario();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor frmBuscaPro = new frmBuscarProveedor();
            //frmCaja.MdiParent = this;
            frmBuscaPro.Show();
        }

        private void txtPrecio_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            string text = txtCantidad.Text;

            if (!decimal.TryParse(text, out _))
            {
                txtCantidad.Text = string.Empty;
                txtCantidad.Focus();
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            int codigoP = int.Parse(txtCodigoP.Text);
            string nombre = txtNombreP.Text;
            int precioCosto = int.Parse(txtPrecio.Text);
            int cantidad = int.Parse(txtCantidad.Text);
            string nombreProveedor = txtIDProveedor.Text;
            string nombreUsuario = txtUsuario.Text;
            Boolean estado = true; 

            string selectedItem = (string)cboEstado.SelectedItem;

            // Ajustar el valor de estado en función de la opción seleccionada
            if (selectedItem == "Activo")
            {
                estado = true;
            }
            else if (selectedItem == "Inactivo")
            {
                estado = false;
            }
            _Inventario.agregarProducto(codigoP, nombre, precioCosto, cantidad, nombreProveedor, estado, nombreUsuario);
        }
    }
}
