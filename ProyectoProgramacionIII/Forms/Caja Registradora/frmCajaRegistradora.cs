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

namespace ProyectoProgramacionIII.Forms.Caja_Registradora
{
    public partial class frmCajaRegistradora : Form
    {
        public frmCajaRegistradora()
        {
            InitializeComponent();
            ConexionBD dbConnection = ConexionBD.Instancia;
        }
        private string InsertarEncabezadoFactura(DateTime fechaCompra, string idTipoPago, decimal compraFinal, int idUsuario)
        {
            string codigoVenta = string.Empty;

            using (SqlConnection conn = ConexionBD.Instancia.GetConnection())
            {
                string query = @"
                    INSERT INTO CajaRegistradora (FechaCompra, IdTipoPago, CompraFinal, IdUsuario)
                    VALUES (@FechaCompra, @IdTipoPago, @CompraFinal, @IdUsuario);
                    
                    SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FechaCompra", fechaCompra);
                cmd.Parameters.AddWithValue("@IdTipoPago", idTipoPago);
                cmd.Parameters.AddWithValue("@CompraFinal", compraFinal);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    conn.Open();
                    object result = cmd.ExecuteScalar();
                    codigoVenta = result != null ? result.ToString() : string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el encabezado de la factura: " + ex.Message);
                }
            }

            return codigoVenta;
        }

        private void InsertarDetalleFactura(string codigoVenta, string codigoProducto, decimal precio, int cantidad, decimal subtotal)
        {
            using (SqlConnection conn = ConexionBD.Instancia.GetConnection())
            {
                string query = @"
                    INSERT INTO DetalleFactura (CodigoVenta, CodigoProducto, Precio, Cantidad, SubTotal)
                    VALUES (@CodigoVenta, @CodigoProducto, @Precio, @Cantidad, @SubTotal)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoVenta", codigoVenta);
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@SubTotal", subtotal);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el detalle de la factura: " + ex.Message);
                }
            }
        }

        private decimal CalcularTotales()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dtgLineasfactura.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    total += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }

            txtTotal.Text = total.ToString("0.00");
            return total;
        }

        private void BuscarProducto(string codigoProducto)
        {
            using (SqlConnection conn = ConexionBD.Instancia.GetConnection())
            {
                string query = @"SELECT Precio FROM Inventario WHERE CodigoProducto = @CodigoProducto";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                try
                {
                    // Verifica si la conexión está cerrada antes de abrirla
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtPrecio.Text = reader["Precio"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Producto no encontrado.");
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el producto: " + ex.Message);
                }
            }
        }


        private void btnFacturar_Click(object sender, EventArgs e)
        {
            DateTime fechaCompra = DateTime.Now;
            string idTipoPago = cboTipoopago.SelectedValue?.ToString();
            int idUsuario;
            if (!int.TryParse(txtUsuario.Text, out idUsuario))
            {
                MessageBox.Show("El ID del usuario no es válido.");
                return;
            }

            if (string.IsNullOrEmpty(idTipoPago))
            {
                MessageBox.Show("Seleccione un tipo de pago.");
                return;
            }

            decimal compraFinal = CalcularTotales();
            string codigoVenta = InsertarEncabezadoFactura(fechaCompra, idTipoPago, compraFinal, idUsuario);

            if (string.IsNullOrEmpty(codigoVenta))
            {
                MessageBox.Show("Error al generar el código de venta.");
                return;
            }

            foreach (DataGridViewRow row in dtgLineasfactura.Rows)
            {
                if (row.Cells["CodigoProducto"].Value != null)
                {
                    string codigoProducto = row.Cells["CodigoProducto"].Value.ToString();
                    decimal precio = Convert.ToDecimal(row.Cells["Precio"].Value);
                    int cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value);
                    decimal subtotal = precio * cantidad;

                    InsertarDetalleFactura(codigoVenta, codigoProducto, precio, cantidad, subtotal);
                }
            }

            MessageBox.Show("Factura generada con éxito.");
        }

        private void frmCajaRegistradora_Load(object sender, EventArgs e)
        {
            //txtCodigoVenta.Text = codigo;
            //var connection = ConexionBD.Instancia.GetConnection();
        }

        private void txtCodigoproducto_TextChanged(object sender, EventArgs e)
        {
            string codigoProducto = txtCodigoproducto.Text.Trim();
            if (!string.IsNullOrEmpty(codigoProducto))
            {
                BuscarProducto(codigoProducto);
            }
        }
    }
}
