using ProyectoProgramacionIII.Interfaces;
using ProyectoProgramacionIII.ModuloSeguridad;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacionIII.Servicios
{
    public class ModuloCajaRegistradora : IntCajaRegistradora
    {
        private IntUsuario moduloSeguridad;

        public ModuloCajaRegistradora() //Se usa el constructor para instanciar el modulo de seguridad y llamar a los metodos del mismo.
        {

            moduloSeguridad = new ModuloSeguridad();

        }

        public void realizarPago(int codigoP, string nombreP, int cantidadP)
        {

            int cantActualizada = cantidadP;

            (string nombre, int precio) = nombreProducto(codigoP);

            string queryDB = "UPDATE Inventario SET Cantidad = @Cantidad, WHERE Nombre = @Nombre";
            string queryDB2 = "INSERT INTO FacturaDiaria (Nombre, Codigo, Cantidad) VALUES (@Nombre, @Codigo, @Cantidad)";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Cantidad", cantActualizada);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }

            using (SqlCommand DBSQL = new SqlCommand(queryDB2))
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Codigo", codigoP);
                DBSQL.Parameters.AddWithValue("@Cantidad", cantActualizada);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }

        }

        void IntCajaRegistradora.calcularPrecio(string nombreUsuario, int codigoP, int cantidadP)
        {

            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
            {

                (string nombre, int precio) = nombreProducto(codigoP);
                // Se muestra en pantalla el nombre del producto con su precio. 

                int precioTotal = 0;
                int cantidad = 0; 

                precioTotal += precio; //Se muestra en pantalla el precio actualizado.
                cantidad += cantidadP; //Se muestra en pantalla la cantidad del producto.

            }
        }

        private (string, int) nombreProducto(int codigo)
        {
            string queryDB = "SELECT Nombre FROM Inventario WHERE Codigo = @Codigo";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            {//En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Codigo", codigo);

                using (SqlDataReader reader = DBSQL.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string nombre =  reader.GetString(0); // Nombre del Producto
                        int precio = reader.GetInt32(1); // Precio del Producto
                        return (nombre, precio);
                    }
                    else
                    {
                        throw new Exception("Producto no encontrado."); // Agregar un mensaje personalizado de alerta.
                    }
                }
            }
        }

    }
}
