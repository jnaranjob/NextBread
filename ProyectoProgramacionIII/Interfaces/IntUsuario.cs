using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacionIII.ModuloSeguridad
{
    public interface IntUsuario
    {

        void agregarUsuario(string nombre, string clave, int permiso, Boolean estado);
        void editarUsuario(string nombre, string clave, int permiso);
        void desactivarUsuario(string nombre, Boolean estado);
        Boolean validarPermiso(string nombre);

    }
}
