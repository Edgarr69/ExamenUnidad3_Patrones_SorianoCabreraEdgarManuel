using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vuelo
    {
        public IVisualizador Visualizador { get; private set; }
        public ITipoVuelo TipoVuelo { get; private set; }

        protected Vuelo(IVisualizador visualizador, ITipoVuelo tipoVuelo)
        {
            Visualizador = visualizador;
            TipoVuelo = tipoVuelo;
        }

        public abstract string Descripcion { get; }
        public abstract double Costo();

        public virtual void MostrarDetalles()
        {
            Visualizador.Mostrar("");
            Visualizador.Mostrar(Descripcion);
            Visualizador.Mostrar("Tipo: " + TipoVuelo.ObtenerDescripcion());
            Visualizador.Mostrar("Costo total: $" + Costo().ToString("0.00") + " USD");
        }
    }
}
