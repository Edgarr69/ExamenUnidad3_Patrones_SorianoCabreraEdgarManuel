using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VueloEconomico : ITipoVuelo
    {
        public string ObtenerDescripcion() { return "Clase Económica"; }
        public double ObtenerCosto() { return 250.00; }
    }
}
