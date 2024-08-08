using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Laboratorio_02
{
    public class HabitacionDoble : Habitación
    {
        public List<HabitacionDoble> listHabitacionDoble = new List<HabitacionDoble>();
        int numero = 8020;
        public string VistaAlMar { get; set; }
        public HabitacionDoble(int numero, double precioPorNoche, string disponibilidad, string clienteAsignado, string vistaAlMar) : base(numero, precioPorNoche, disponibilidad, clienteAsignado)
        {
            VistaAlMar = vistaAlMar;
        }
        public void AgregarHabitacion()
        {
            Console.Write("Ingrese la cantidad de habitaciones que quiere registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                numero += 1;
                Console.Write("Ingrese el precio por noche de la habitación: Q");
                double precioPorNoche = double.Parse(Console.ReadLine());
                Console.Write("¿La habitación tiene vista al mar? SI/NO");
                string vista = Console.ReadLine().ToUpper();
                if (vista == "SI")
                {
                    bool vistaAlMar = true;
                    listHabitacionDoble.Add(new HabitacionDoble(numero, precioPorNoche, "Disponible", null, "Si"));
                }
                else if (vista == "NO")
                {
                    bool vistaAlMar = false;
                    listHabitacionDoble.Add(new HabitacionDoble(numero, precioPorNoche, "Disponible", null, "No"));
                }
                else
                {
                    Console.WriteLine("No es una opción válida.");
                }
            }
            Console.Clear();
            Console.WriteLine("Habitaciones registradas correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Información de las habitaciones: ");
            foreach (HabitacionDoble habitacion in listHabitacionDoble)
            {
                Console.WriteLine($"Número de habitación: {habitacion.Numero}");
                Console.WriteLine($"Precio de habitación: {habitacion.PrecioPorNoche}");
                Console.WriteLine($"Disponibilidad de habitación: {habitacion.Disponibilidad}");
                Console.WriteLine($"Cliente de la habitación: {habitacion.ClienteAsignado}");
                Console.WriteLine($"Vista al mar: {habitacion.VistaAlMar}");
            }
            Console.WriteLine("\nHabitaciones registradas correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
        }
    }
}
