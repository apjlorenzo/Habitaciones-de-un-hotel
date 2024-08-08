using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    internal class HabitacionDeluxe : Habitación
    {
        public List<HabitacionDeluxe> listDeluxe = new List<HabitacionDeluxe>();
        int numero = 10020;
        //Atributos
        public string ServiciosExtras { get; set; }
        //MétodoConstructos
        public HabitacionDeluxe(int numero, double precioPorNoche, string disponibilidad, string clienteAsignado, string serviciosExtras) : base(numero, precioPorNoche, disponibilidad, clienteAsignado)
        {
            ServiciosExtras = serviciosExtras;
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
                Console.Write("Ingrese los servicios extras: ");
                string serviciosExtras = Console.ReadLine();

                listDeluxe.Add(new HabitacionDeluxe(numero, precioPorNoche, "Disponible", null, serviciosExtras));
            }
            Console.Clear();
            Console.WriteLine("Habitaciones registradas correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
            Console.ReadKey();
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("\nHabitaciones deluxe.");
            Console.WriteLine("Información de las habitaciones: ");
            foreach (HabitacionDeluxe habitacion in listDeluxe)
            {
                Console.WriteLine($"\nNúmero de habitación: {habitacion.Numero}");
                Console.WriteLine($"Precio de habitación: {habitacion.PrecioPorNoche}");
                Console.WriteLine($"Disponibilidad de habitación: {habitacion.Disponibilidad}");
                Console.WriteLine($"Cliente asignado: {habitacion.ClienteAsignado}");
                Console.WriteLine($"Número de camas: {habitacion.ServiciosExtras}");
            }

        }
        public new void EliminarHabitacion()
        {
            Console.Clear();
            Console.Write("Ingrese el numero de la habitacion que quiere eliminar: ");
            int numero = int.Parse(Console.ReadLine());
            HabitacionDeluxe encontrar = listDeluxe.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                listDeluxe.Remove(encontrar);
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
            HabitacionDeluxe encontrar = listDeluxe.Find(p => p.Numero == numero);
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
            HabitacionDeluxe encontrar = listDeluxe.Find(p => p.Numero == numero);
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
