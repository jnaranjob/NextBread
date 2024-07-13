using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacionIII.Interfaces
{
    public interface IntCajaRegistradora
    {
        void calcularPrecio(string nombreUsuario, int codigo, int cantidadP);
        void realizarPago(int codigo, string nombreP ,int cantidadP);

    }
}
