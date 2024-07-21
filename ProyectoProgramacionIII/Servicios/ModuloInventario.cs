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
    public class ModuloInventario : IntInventario
    {

        private IntUsuario moduloSeguridad;

        public ModuloInventario()
        {
            
            moduloSeguridad = new ModuloSeguridad();

        }

        public void agregarProducto(int codigoP, string nombre, int precioCosto, int cantidad, string nombreProveedor, bool estado, string nombreUsuario)
        {
            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
            {
                string queryDB = "INSERT INTO Inventario (Codigo, Nombre, Precio, Cantidad, Proveedor, Estado) VALUES (@Codigo, @Nombre, @Precio, @Cantidad, @Proveedor, @Estado)";
                using (SqlCommand DBSQL = new SqlCommand(queryDB))
                { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                    DBSQL.Parameters.AddWithValue("@Codigo", codigoP);
                    DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                    DBSQL.Parameters.AddWithValue("@Precio", precioCosto);
                    DBSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                    DBSQL.Parameters.AddWithValue("@Proveedor", nombreProveedor);
                    DBSQL.Parameters.AddWithValue("@Estado", estado);

                    DBSQL.ExecuteNonQuery();

                    //Faltaria los comandos de abrir y cerrar la conexion.
                }
            }

        }

        public void desactivarProducto(string nombre, bool estado)
        {
            string queryDB = "UPDATE Inventario SET Estado = @Estado WHERE Nombre = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Estado", estado);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }
        }

        public void editarProducto(string nombre, int precioCosto, int cantidad, string nombreProveedor, string nombreUsuario)
        {

            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
            {
                string queryDB = "UPDATE Proveedor SET Nombre = @Nombre, Precio = @Precio, Cantidad = @Cantidad, Proveedor = @Proveedor, Estado = @Estado WHERE Nombre = @Nombre";

                using (SqlCommand DBSQL = new SqlCommand(queryDB))
                { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                    DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                    DBSQL.Parameters.AddWithValue("@Precio", precioCosto);
                    DBSQL.Parameters.AddWithValue("@Cantidad", cantidad);
                    DBSQL.Parameters.AddWithValue("@Proveedor", nombreProveedor);

                    DBSQL.ExecuteNonQuery();

                    //Faltaria los comandos de abrir y cerrar la conexion.
                }
            }

        }
    }
}
