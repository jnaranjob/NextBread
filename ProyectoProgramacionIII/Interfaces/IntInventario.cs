using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacionIII.Interfaces
{
    public interface IntInventario
    {
        void agregarProducto(int codigoP, string nombre, int precioCosto, int cantidad, string nombreProveedor, Boolean estado, string nombreUsuario);
        void editarProducto(string nombre, int precioCosto, int cantidad, string nombreProveedor, string nombreUsuario);
        void desactivarProducto(string nombre, Boolean estado);

    }
}
