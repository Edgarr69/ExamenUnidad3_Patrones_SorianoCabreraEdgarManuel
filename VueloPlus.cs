using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VueloPlus : ITipoVuelo
    {
        public string ObtenerDescripcion() { return "Clase Plus"; }
        public double ObtenerCosto() { return 500.00; }
    }
}
