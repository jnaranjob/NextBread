using ProyectoProgramacionIII.Conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoProgramacionIII.Forms.Caja_Registradora
{
    public partial class frmCajaRegistradora : Form
    {
        private Dictionary<string, string> tiposPago = new Dictionary<string, string>
        {
            { "01", "Efectivo" },
            { "02", "Tarjeta" },
            { "03", "Sinpe Movil" },
            { "04", "Otro" }
        };

        private SqlConnection connection;

        public frmCajaRegistradora()
        {
            InitializeComponent();
            ConexionBD dbConnection = ConexionBD.Instancia;
            connection = dbConnection.GetConnection(); // Obtener la conexión desde la instancia
            cboTipoopago.DataSource = new BindingSource(tiposPago, null);
            cboTipoopago.DisplayMember = "Value";
            cboTipoopago.ValueMember = "Key";
            txtCantidad.KeyDown += new KeyEventHandler(txtCantidad_KeyDown);
        }

        private void frmCajaRegistradora_Load(object sender, EventArgs e)
        {
            dtgLineasfactura.Columns.Add("CodigoProducto", "Código Producto");
            dtgLineasfactura.Columns.Add("Precio", "Precio");
            dtgLineasfactura.Columns.Add("Cantidad", "Cantidad");
            dtgLineasfactura.Columns.Add("SubTotal", "SubTotal");

            dtgLineasfactura.Columns["CodigoProducto"].ReadOnly = true; 
            dtgLineasfactura.Columns["Precio"].ReadOnly = true; 
            dtgLineasfactura.Columns["Cantidad"].ReadOnly = false; 
            dtgLineasfactura.Columns["SubTotal"].ReadOnly = true; 

            cboTipoopago.DataSource = new BindingSource(tiposPago, null);
            cboTipoopago.DisplayMember = "Value";
            cboTipoopago.ValueMember = "Key";
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                AgregarProductoAlGrid();
                e.Handled = true;  // Evita el beep de la tecla Enter
                e.SuppressKeyPress = true;
            }
        }

        private void AgregarProductoAlGrid()
        {
            if (string.IsNullOrEmpty(txtCodigoproducto.Text) ||
            string.IsNullOrEmpty(txtPrecio.Text) ||
            string.IsNullOrEmpty(txtCantidad.Text))
            {
                MessageBox.Show("Debe completar los campos de producto, precio y cantidad.");
                return;
            }

            string codigoProducto = txtCodigoproducto.Text.Trim();
            decimal precio = Convert.ToDecimal(txtPrecio.Text.Trim());
            int cantidad = Convert.ToInt32(txtCantidad.Text.Trim());

            // Verificar disponibilidad en inventario
            if (!VerificarDisponibilidadProducto(codigoProducto, cantidad))
            {
                MessageBox.Show("Cantidad insuficiente en inventario.");
                return;
            }

            decimal subtotal = precio * cantidad;

            dtgLineasfactura.Rows.Add(codigoProducto, precio, cantidad, subtotal);

            // Actualizar los totales
            CalcularTotales();

            // Limpiar campos y enfocar
            txtCodigoproducto.Clear();
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtCodigoproducto.Focus();
        }

        private bool VerificarDisponibilidadProducto(string codigoProducto, int cantidadRequerida)
        {
            string query = @"SELECT Cantidad FROM Inventario WHERE CodigoProducto = @CodigoProducto";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }

                    int cantidadDisponible = Convert.ToInt32(cmd.ExecuteScalar());
                    return cantidadDisponible >= cantidadRequerida;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al verificar disponibilidad del producto: " + ex.Message);
                    return false;
                }
            }
        }

        private string InsertarEncabezadoFactura(DateTime fechaCompra, string idTipoPago, decimal compraFinal, int idUsuario)
        {
            string codigoVenta = string.Empty;

            string insertQuery = @"
                    INSERT INTO CajaRegistradora (FechaCompra, IdTipoPago, CompraFinal, IdUsuario)
                    VALUES (@FechaCompra, @IdTipoPago, @CompraFinal, @IdUsuario);";

            string selectQuery = @"
                    SELECT TOP 1 CodigoVenta 
                    FROM TempCodigoVenta
                    ORDER BY CodigoVenta DESC;";

            using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
            {
                insertCmd.Parameters.AddWithValue("@FechaCompra", fechaCompra);
                insertCmd.Parameters.AddWithValue("@IdTipoPago", idTipoPago);
                insertCmd.Parameters.AddWithValue("@CompraFinal", compraFinal);
                insertCmd.Parameters.AddWithValue("@IdUsuario", idUsuario);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    insertCmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el encabezado de la factura: " + ex.Message);
                    return codigoVenta;  // Salir temprano si hay un error
                }
            }

            using (SqlCommand selectCmd = new SqlCommand(selectQuery, connection))
            {
                try
                {
                    using (SqlDataReader reader = selectCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            codigoVenta = reader["CodigoVenta"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el código de venta: " + ex.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            }

            return codigoVenta;
        }


        private void InsertarDetalleFactura(string codigoVenta, string codigoProducto, decimal precio, int cantidad, decimal subtotal)
        {
            string query = @"
                INSERT INTO DetalleFactura (CodigoVenta, CodigoProducto, Precio, Cantidad, SubTotal)
                VALUES (@CodigoVenta, @CodigoProducto, @Precio, @Cantidad, @SubTotal);

                UPDATE Inventario
                SET Cantidad = Cantidad - @Cantidad
                WHERE CodigoProducto = @CodigoProducto";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CodigoVenta", codigoVenta);
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);
                cmd.Parameters.AddWithValue("@Precio", precio);
                cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                cmd.Parameters.AddWithValue("@SubTotal", subtotal);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar el detalle de la factura y actualizar inventario: " + ex.Message);
                }
            }
        }

        private decimal CalcularTotales()
        {
            decimal total = 0;
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dtgLineasfactura.Rows)
            {
                if (row.Cells["SubTotal"].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells["SubTotal"].Value);
                }
            }
            total = subtotal;
            txtSubtotal.Text = subtotal.ToString("0.00");
            txtTotal.Text = total.ToString("0.00");

            return total;
        }

        private void BuscarProducto(string codigoProducto)
        {
            string query = @"SELECT Precio FROM Inventario WHERE CodigoProducto = @CodigoProducto";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@CodigoProducto", codigoProducto);

                try
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
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
            int idUsuario = 1;
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

            txtCodigoVenta.Text = codigoVenta;

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

            dtgLineasfactura.Rows.Clear();
            txtCodigoVenta.Text = "";
        }

        private void txtCodigoproducto_TextChanged(object sender, EventArgs e)
        {
            string codigoProducto = txtCodigoproducto.Text.Trim();
            if (!string.IsNullOrEmpty(codigoProducto))
            {
                BuscarProducto(codigoProducto);
            }
        }

        private void cboTipoopago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoopago.SelectedValue != null)
            {
                txtDescripcion.Text = cboTipoopago.Text;
            }
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCantidad.Text))
            {
                AgregarProductoAlGrid();
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            if (dtgLineasfactura.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el artículo seleccionado?",
                                                      "Confirmar Eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dtgLineasfactura.SelectedRows)
                    {
                        if (!row.IsNewRow)
                        {
                            dtgLineasfactura.Rows.Remove(row);
                        }
                    }
                    CalcularTotales();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void dtgLineasfactura_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dtgLineasfactura.Columns["Cantidad"].Index && e.RowIndex >= 0)
            {
                int cantidad = Convert.ToInt32(dtgLineasfactura.Rows[e.RowIndex].Cells["Cantidad"].Value);
                decimal precio = Convert.ToDecimal(dtgLineasfactura.Rows[e.RowIndex].Cells["Precio"].Value);

                decimal subtotal = precio * cantidad;
                dtgLineasfactura.Rows[e.RowIndex].Cells["SubTotal"].Value = subtotal;

                CalcularTotales();
            }
        }
    }
}

