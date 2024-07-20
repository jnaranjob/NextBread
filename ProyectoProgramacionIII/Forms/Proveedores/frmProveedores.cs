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
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                // Abrir la conexión
                ConexionBD.Instancia.AbrirConexion();

                // Obtener el último IdProveedor
                string query = "SELECT ISNULL(MAX(IdProveedor), 0) + 1 FROM Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, ConexionBD.Instancia.GetConnection()))
                {
                    int nuevoIdProveedor = (int)cmd.ExecuteScalar();
                    txtUsuario.Text = nuevoIdProveedor.ToString();
                }

                int idUsuarioActual = ObtenerIdUsuarioActual();
                txtUsuario.Text = idUsuarioActual.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }

        private int ObtenerIdUsuarioActual()
        {
            return 1; // Retorna un IdUsuario ficticio para este ejemplo
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.Instancia.AbrirConexion();
                string query = "INSERT INTO Proveedor (Nombre, Estado, IdUsuario) VALUES (@Nombre, @Estado, @IdUsuario)";
                using (SqlCommand cmd = new SqlCommand(query, ConexionBD.Instancia.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@Estado", cboEstado.SelectedItem.ToString() == "Activo" ? 1 : 0);
                    cmd.Parameters.AddWithValue("@IdUsuario", int.Parse(txtUsuario.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Proveedor guardado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el proveedor: " + ex.Message);
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }

        
        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {

        }
    }
}
