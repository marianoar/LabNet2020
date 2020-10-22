using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            bool isNumber = false;
            int pasajeros;
            string tipo;

            List<Transporte> transportes;

            transportes = new List<Transporte>();

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(" - - - Ejercicio 1 - - -");
                Console.WriteLine();

                if (i < 6)
                {
                    tipo = "Avion";
                }
                else
                {
                    tipo = "Automovil";
                }

                Console.WriteLine(" Ingrese la cantidad de pasajeros del " + tipo + " Nº {0}", i);
                Console.Write(" Pasajeros: ");
                aux = Console.ReadLine();
                isNumber = int.TryParse(aux, out pasajeros);

                while ((!isNumber) || (pasajeros < 0))
                {
                    Console.WriteLine("Error. Ingrese nuevamente cantidad de pasajeros del transporte Nº{0}", i + ".");
                    Console.Write("Pasajeros: ");
                    aux = Console.ReadLine();
                    isNumber = int.TryParse(aux, out pasajeros);
                }
                while ((tipo == "Avion") && (pasajeros > 850))
                {
                    Console.WriteLine("Error. El avion mas grande del mundo puede llevar hasta 850 pasajeros. Ingrese nuevamente cantidad de pasajeros del transporte Nº{0}", i + ".");
                    Console.Write("Pasajeros: ");
                    aux = Console.ReadLine();
                    isNumber = int.TryParse(aux, out pasajeros);
                    while ((!isNumber) || (pasajeros < 0))
                    {
                        Console.WriteLine("Error. Ingrese nuevamente cantidad de pasajeros del transporte {0}", i + ".");
                        Console.Write("Pasajeros: ");
                        aux = Console.ReadLine();
                        isNumber = int.TryParse(aux, out pasajeros);
                    }
                }
                while ((tipo == "Automovil") && (pasajeros > 5))
                {
                    Console.WriteLine("Error. Un automovil no puede transportar mas de 5 pasajeros. Ingrese nuevamente cantidad de pasajeros del transporte Nº{0}", i + ".");
                    Console.Write("Pasajeros: ");
                    aux = Console.ReadLine();
                    isNumber = int.TryParse(aux, out pasajeros);
                    while ((!isNumber) || (pasajeros < 0))
                    {
                        Console.WriteLine("Error. Ingrese nuevamente cantidad de pasajeros del transporte {0}", i + ".");
                        Console.Write("Pasajeros: ");
                        aux = Console.ReadLine();
                        isNumber = int.TryParse(aux, out pasajeros);
                    }
                }

                Console.Clear();

                if (i < 6)
                {
                    Avion avion = new Avion(pasajeros);
                    transportes.Add(avion);
                }
                else
                {
                    Automovil automovil = new Automovil(pasajeros);
                    transportes.Add(automovil);
                }

            }
            Console.WriteLine(" - - - Ejercicio 1 - - -");
            Console.WriteLine();
            for (int i = 0; i < transportes.Count; i++)
            {
                int numero = i + 1;
                Console.WriteLine("El transporte " + numero  + " es un " + transportes[i].Definir() + " y posee " + transportes[i].Pasajeros + " pasajeros.");

            }
            Console.ReadKey();
        }
    }
}
