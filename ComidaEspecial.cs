using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ComidaEspecial : VueloDecorador
    {
        private string tipoComida;

        public ComidaEspecial(Vuelo vuelo, string tipoComida)
            : base(vuelo)
        {
            this.tipoComida = tipoComida;
        }

        public override string Descripcion
        {
            get { return vuelo.Descripcion + ", incluye comida " + tipoComida; }
        }

        public override double Costo()
        {
            return vuelo.Costo() + 40.00;
        }
    }
}
