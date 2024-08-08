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
            Console.Clear();
            Console.WriteLine("Información de las habitaciones: ");
            foreach (HabitacionSimple habitacion in listHabitacionSimple)
            {
                Console.WriteLine($"Número de habitación: {habitacion.Numero}");
                Console.WriteLine($"Precio de habitación: {habitacion.PrecioPorNoche}");
                Console.WriteLine($"Disponibilidad de habitación: {habitacion.Disponibilidad}");
                Console.WriteLine($"Cliente asignado: {habitacion.ClienteAsignado}");
                Console.WriteLine($"Número de camas: {habitacion.NumeroDeCamas}");
            }
            Console.WriteLine("Habitaciones registradas correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
            Console.ReadKey();
        }
    }
}
