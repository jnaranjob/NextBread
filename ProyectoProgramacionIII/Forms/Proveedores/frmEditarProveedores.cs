using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacionIII.Forms.Proveedores
{
    public partial class frmEditarProveedores : Form
    {

        public frmEditarProveedores()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscarProveedor frmBusPro = new frmBuscarProveedor();
            //frmCaja.MdiParent = this;
            frmBusPro.Show();
        }

        private void frmEditarProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
