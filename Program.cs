using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("====================================");
            Console.WriteLine("      SIMULADOR DE VUELO AEREO");
            Console.WriteLine("====================================");
            Console.WriteLine();

            Console.Write("Origen del vuelo: ");
            string origen = Console.ReadLine();

            Console.Write("Destino del vuelo: ");
            string destino = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Seleccione el tipo de vuelo:");
            Console.WriteLine("1. Economico $250");
            Console.WriteLine("2. Basico $350");
            Console.WriteLine("3. Plus $500");
            Console.WriteLine("4. Ejecutivo $700");
            Console.Write("Opcion: ");
            string opcionClase = Console.ReadLine();

            ITipoVuelo tipoVuelo;
            if (opcionClase == "2")
                tipoVuelo = new VueloBasico();
            else if (opcionClase == "3")
                tipoVuelo = new VueloPlus();
            else if (opcionClase == "4")
                tipoVuelo = new VueloEjecutivo();
            else
                tipoVuelo = new VueloEconomico();

            IVisualizador visualizador = new VisualizadorConsola();
            Vuelo vuelo = new VueloBase(visualizador, tipoVuelo, origen, destino);

            Console.WriteLine();
            Console.WriteLine("--- Personaliza tu vuelo ---");

            
            Console.WriteLine();
            Console.Write("Deseas agregar equipaje adicional por $35?: ");
            string resp = Console.ReadLine().ToLower();
            if (resp == "si")
            {
                Console.Write("Cuantas maletas deseas agregar?: ");
                int maletas;
                if (int.TryParse(Console.ReadLine(), out maletas))
                {
                    vuelo = new EquipajeAdicional(vuelo, maletas);
                }
            }

            
            Console.WriteLine();
            Console.Write("Deseas incluir comida especial durante el vuelo por $40?: ");
            resp = Console.ReadLine().ToLower();
            if (resp == "si")
            {
                Console.Write("Tipo de comida (vegetariana, gourmet, infantil): ");
                string tipoComida = Console.ReadLine();
                vuelo = new ComidaEspecial(vuelo, tipoComida);
            }

            
            Console.WriteLine();
            Console.Write("Deseas conexion WiFi a bordo por $25?: ");
            resp = Console.ReadLine().ToLower();
            if (resp == "si")
            {
                vuelo = new WifiABordo(vuelo);
            }

            
            Console.WriteLine();
            Console.Write("Deseas embarque prioritario por $15?: ");
            resp = Console.ReadLine().ToLower();
            if (resp == "si")
            {
                vuelo = new EmbarquePrioritario(vuelo);
            }

            Console.WriteLine();
            Console.WriteLine("====================================");
            Console.WriteLine("   RESUMEN FINAL DEL VUELO");
            Console.WriteLine("====================================");

            vuelo.MostrarDetalles();

            Console.WriteLine();
            Console.WriteLine("Buen viaje!");
            Console.ReadKey();
        }
    }
}