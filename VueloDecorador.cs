using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class VueloDecorador : Vuelo
    {
        protected Vuelo vuelo;

        public VueloDecorador(Vuelo vuelo)
            : base(vuelo.Visualizador, vuelo.TipoVuelo)
        {
            this.vuelo = vuelo;
        }
    }
}
