using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EquipajeAdicional : VueloDecorador
    {
        private int maletas;

        public EquipajeAdicional(Vuelo vuelo, int maletas)
            : base(vuelo)
        {
            this.maletas = maletas;
        }

        public override string Descripcion
        {
            get { return vuelo.Descripcion + ", con " + maletas + " maleta(s) adicional(es)"; }
        }

        public override double Costo()
        {
            return vuelo.Costo() + (maletas * 35.00);
        }
    }
}
