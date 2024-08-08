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
            Console.Clear();
            Console.Write("Ingrese la cantidad de habitaciones que quiere registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                numero += 1;
                Console.Write("Ingrese el precio por noche de la habitación: Q");
                double precioPorNoche = double.Parse(Console.ReadLine());
                Console.Write("¿La habitación tiene vista al mar? SI/NO ");
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
            Console.ReadKey();
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("\nHabitaciones dobles");
            Console.WriteLine("Información de las habitaciones: ");
            foreach (HabitacionDoble habitacion in listHabitacionDoble)
            {
                Console.WriteLine($"\nNúmero de habitación: {habitacion.Numero}");
                Console.WriteLine($"Precio de habitación: {habitacion.PrecioPorNoche}");
                Console.WriteLine($"Disponibilidad de habitación: {habitacion.Disponibilidad}");
                Console.WriteLine($"Cliente de la habitación: {habitacion.ClienteAsignado}");
                Console.WriteLine($"Vista al mar: {habitacion.VistaAlMar}");
            }
        }
        public new void EliminarHabitacion()
        {
            Console.Clear();
            Console.Write("Ingrese el numero de la habitacion que quiere eliminar: ");
            int numero = int.Parse(Console.ReadLine());
            HabitacionDoble encontrar = listHabitacionDoble.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                listHabitacionDoble.Remove(encontrar);
                Console.WriteLine("Se ha eliminado correctamente.");
                Console.WriteLine("\nPresione cualquier tecla para continuar: ");
            }
            else
            {
                Console.WriteLine("No hay ninguna habitacion con ese numero.");
            }
            Console.ReadKey();
        }
        public void AsignarCliente()
        {
            Console.Write("Ingrese el numero de la habitacion: ");
            int numero = int.Parse(Console.ReadLine());
            HabitacionDoble encontrar = listHabitacionDoble.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                Console.Write("Ingrese el nombre del cliente que quiere asignar: ");
                string cliente = Console.ReadLine();
                encontrar.ClienteAsignado = cliente;
                encontrar.Disponibilidad = "No disponible";
                Console.WriteLine("Cliente asignado correctamente a la habitación.");
                Console.WriteLine("Presione cualquier tecla para continuar: ");

            }
            else
            {
                Console.WriteLine("No hay ninguna habitacion con ese numero");
            }
        }

        public void LiberarHabitacion()
        {
            Console.Write("Ingrese el numero de habitacion que quiere liberar: ");
            int numero = int.Parse(Console.ReadLine());
            HabitacionDoble encontrar = listHabitacionDoble.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                encontrar.Disponibilidad = "Disponible";
                encontrar.ClienteAsignado = null;
                Console.WriteLine("Habitación liberada correctamente.");
                Console.WriteLine("\nPresione cualquier tecla para continuar: ");
            }
            else
            {
                Console.WriteLine("No hay ninguna habitacion con ese numero.");
            }
        }
    }
}
