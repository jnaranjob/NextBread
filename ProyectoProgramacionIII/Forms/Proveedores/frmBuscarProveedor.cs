using ProyectoProgramacionIII.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoProgramacionIII.Forms.Proveedores
{
    public partial class frmBuscarProveedor : Form
    {
        public frmBuscarProveedor()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int idProveedor;
            if (int.TryParse(txtIDProveedor.Text, out idProveedor))
            {
                try
                {
                    ConexionBD.Instancia.AbrirConexion();

                    string query = "SELECT IdProveedor, Nombre, Estado, IdUsuario FROM Proveedor WHERE IdProveedor = @IdProveedor";
                    using (SqlCommand cmd = new SqlCommand(query, ConexionBD.Instancia.GetConnection()))
                    {
                        cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        dgvProveedor.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el proveedor: " + ex.Message);
                }
                finally
                {
                    ConexionBD.Instancia.CerrarConexion();
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ID de proveedor válido.");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                int idProveedor = Convert.ToInt32(dgvProveedor.SelectedRows[0].Cells["IdProveedor"].Value);

                frmEditarProveedores frmEditar = new frmEditarProveedores();
                frmEditar.Show();
                this.Close(); // Cierra el formulario de búsqueda si es necesario
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para editar.");
            }
        }
    }
}
