using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    public class HabitacionSimple : Habitación
    {
        public List<HabitacionSimple> listHabitacionSimple = new List<HabitacionSimple>();
        int numero = 5020;
        //Atributos
        public int NumeroDeCamas { get; set; }
        //MétodoConstructos
        public HabitacionSimple(int numero, double precioPorNoche, string disponibilidad, string clienteAsignado, int numeroDeCamas) : base(numero, precioPorNoche, disponibilidad, clienteAsignado)
        {
            NumeroDeCamas = numeroDeCamas;
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
                Console.Write("Ingrese el número de camas: ");
                int numeroDeCamas = int.Parse(Console.ReadLine());

                listHabitacionSimple.Add(new HabitacionSimple(numero, precioPorNoche, "Disponible", null, numeroDeCamas));
            }
            Console.Clear();
            Console.WriteLine("Habitaciones registradas correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
            Console.ReadKey();
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("\nHabitaciones simples.");
            Console.WriteLine("Información de las habitaciones: ");
            foreach (HabitacionSimple habitacion in listHabitacionSimple)
            {
                Console.WriteLine($"\nNúmero de habitación: {habitacion.Numero}");
                Console.WriteLine($"Precio de habitación: {habitacion.PrecioPorNoche}");
                Console.WriteLine($"Disponibilidad de habitación: {habitacion.Disponibilidad}");
                Console.WriteLine($"Cliente asignado: {habitacion.ClienteAsignado}");
                Console.WriteLine($"Número de camas: {habitacion.NumeroDeCamas}");
            }
        }
        public new void EliminarHabitacion()
        {
            Console.Clear();
            Console.Write("Ingrese el numero de la habitacion que quiere eliminar: ");
            int numero = int.Parse(Console.ReadLine());
            HabitacionSimple encontrar = listHabitacionSimple.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                listHabitacionSimple.Remove(encontrar);
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
            HabitacionSimple encontrar = listHabitacionSimple.Find(p=>p.Numero == numero);
            if (encontrar != null)
            {
                Console.Write("Ingrese el nombre del cliente que quiere asignar: ");
                string cliente = Console.ReadLine();
                encontrar.ClienteAsignado = cliente;
                encontrar.Disponibilidad = "No disponible";
                Console.WriteLine("Cliente asignado correctamente a la habitación.");
                Console.WriteLine("\nPresione cualquier tecla para continuar: ");
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
            HabitacionSimple encontrar = listHabitacionSimple.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                encontrar.Disponibilidad = "Disponible";
                encontrar.ClienteAsignado = null;
            }
            else
            {
                Console.WriteLine("No hay ninguna habitacion con ese numero.");
            }
        }
    }
}
