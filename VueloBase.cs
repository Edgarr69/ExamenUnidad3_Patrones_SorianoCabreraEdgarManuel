using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class VueloBase : Vuelo
    {
        private string origen;
        private string destino;

        public VueloBase(IVisualizador visualizador, ITipoVuelo tipoVuelo, string origen, string destino)
            : base(visualizador, tipoVuelo)
        {
            this.origen = origen;
            this.destino = destino;
        }

        public override string Descripcion
        {
            get { return "Vuelo de " + origen + " a " + destino; }
        }

        public override double Costo()
        {
            return TipoVuelo.ObtenerCosto();
        }
    }
}
