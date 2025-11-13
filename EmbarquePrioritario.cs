using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmbarquePrioritario : VueloDecorador
    {
        public EmbarquePrioritario(Vuelo vuelo)
            : base(vuelo)
        {
        }

        public override string Descripcion
        {
            get { return vuelo.Descripcion + ", con embarque prioritario"; }
        }

        public override double Costo()
        {
            return vuelo.Costo() + 15.00;
        }
    }
}
