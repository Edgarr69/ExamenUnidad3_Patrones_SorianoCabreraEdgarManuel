using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class WifiABordo : VueloDecorador
    {
        public WifiABordo(Vuelo vuelo)
            : base(vuelo)
        {
        }

        public override string Descripcion
        {
            get { return vuelo.Descripcion + ", con conexión Wi-Fi a bordo"; }
        }

        public override double Costo()
        {
            return vuelo.Costo() + 25.00;
        }
    }
}
