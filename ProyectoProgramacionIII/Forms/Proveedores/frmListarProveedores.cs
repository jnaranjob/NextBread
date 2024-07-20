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
    public partial class frmListarProveedores : Form
    {
        public frmListarProveedores()
        {
            InitializeComponent();
        }
        private void frmListarProveedores_Load(object sender, EventArgs e)
        {
            CargarProveedores();
        }
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            if (dgvListaProveedores.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este proveedor?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        ConexionBD.Instancia.AbrirConexion();

                        int idProveedor = Convert.ToInt32(dgvListaProveedores.SelectedRows[0].Cells["IdProveedor"].Value);
                        string query = "DELETE FROM Proveedor WHERE IdProveedor = @IdProveedor";
                        using (SqlCommand cmd = new SqlCommand(query, ConexionBD.Instancia.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Proveedor eliminado correctamente.");
                            CargarProveedores();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el proveedor: " + ex.Message);
                    }
                    finally
                    {
                        ConexionBD.Instancia.CerrarConexion();
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un proveedor para eliminar.");
            }
        }
        private void CargarProveedores()
        {
            try
            {
                ConexionBD.Instancia.AbrirConexion();

                string query = "SELECT IdProveedor, Nombre, Estado, IdUsuario FROM Proveedor";
                using (SqlCommand cmd = new SqlCommand(query, ConexionBD.Instancia.GetConnection()))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvListaProveedores.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los proveedores: " + ex.Message);
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }

        private void btnInactivar_Click(object sender, EventArgs e)
        {
            try
            {
                ConexionBD.Instancia.AbrirConexion();

                foreach (DataGridViewRow row in dgvListaProveedores.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["Inactivar"].Value))
                    {
                        int idProveedor = Convert.ToInt32(row.Cells["IdProveedor"].Value);
                        DialogResult result = MessageBox.Show($"¿Está seguro de que desea inactivar al proveedor con ID {idProveedor}?", "Confirmar Inactivación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                        if (result == DialogResult.Yes)
                        {
                            string query = "UPDATE Proveedor SET Estado = 0 WHERE IdProveedor = @IdProveedor";
                            using (SqlCommand cmd = new SqlCommand(query, ConexionBD.Instancia.GetConnection()))
                            {
                                cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                MessageBox.Show("Proveedores inactivados correctamente.");
                // Recargar los proveedores después de la inactivación
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al inactivar los proveedores: " + ex.Message);
            }
            finally
            {
                ConexionBD.Instancia.CerrarConexion();
            }
        }
    }
}
