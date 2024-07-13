using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacionIII.Interfaces
{
    public interface IntProveedor
    {

        void agregarProveedor(string nombre, Boolean estado, string nombreUsuario);

        void editarProveedor(string nombre, string nombreUsuario);

        void DesactivarProveedor(string nombre, Boolean estado);


    }
}
