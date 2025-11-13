using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VueloEjecutivo : ITipoVuelo
    {
        public string ObtenerDescripcion() { return "Clase Ejecutiva"; }
        public double ObtenerCosto() { return 700.00; }
    }
}
