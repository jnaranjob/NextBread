using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoProgramacionIII.ModuloSeguridad
{
    public abstract class Usuario
    {
        public string nombre { get; set; }
        public string clave { get; set; }
        public int permiso { get; set; }
        public Boolean estado { get; set; }
    }
}
