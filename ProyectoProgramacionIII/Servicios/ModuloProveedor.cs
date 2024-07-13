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
    public class ModuloProveedor : IntProveedor
    {

        private IntUsuario moduloSeguridad;

        public ModuloProveedor()
        {
            moduloSeguridad = new ModuloSeguridad();
        }   

        public void agregarProveedor(string nombre, bool estado, string nombreUsuario)
        {

            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
            {
                string queryDB = "INSERT INTO Proveedores (Nombre, Estado) VALUES (@Nombre, @Estado)";
                using (SqlCommand DBSQL = new SqlCommand(queryDB))
                { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                    DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                    DBSQL.Parameters.AddWithValue("@Estado", estado);

                    DBSQL.ExecuteNonQuery();

                    //Faltaria los comandos de abrir y cerrar la conexion.
                }
            }
        }

        public void DesactivarProveedor(string nombre, bool estado)
        {

            string queryDB = "UPDATE Proveedor SET Estado = @Estado WHERE Nombre = @Nombre";

            using (SqlCommand DBSQL = new SqlCommand(queryDB))
            { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                DBSQL.Parameters.AddWithValue("@Nombre", nombre);
                DBSQL.Parameters.AddWithValue("@Estado", estado);

                DBSQL.ExecuteNonQuery();

                //Faltaria los comandos de abrir y cerrar la conexion.
            }
        }

        public void editarProveedor(string nombre, string nombreUsuario)
        {

            Boolean tipoPermiso = moduloSeguridad.validarPermiso(nombreUsuario);

            if (tipoPermiso == false)
            {

                //Se debe mostrar un aviso donde se le diga al usuario
                //que no cuenta con permisos suficientes para utilizar el modulo actual.

            }
            else
            {
                string queryDB = "UPDATE Proveedor SET Nombre = @Nombre WHERE Nombre = @Nombre";

                using (SqlCommand DBSQL = new SqlCommand(queryDB))
                { //En el comando falta agregar la linea de codigo de la conexion de la DB.

                    DBSQL.Parameters.AddWithValue("@Nombre", nombre);

                    DBSQL.ExecuteNonQuery();

                    //Faltaria los comandos de abrir y cerrar la conexion.
                }
            }
        }
    }
}
