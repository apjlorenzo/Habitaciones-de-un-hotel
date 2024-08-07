using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    public class Habitación
    {
        public List<Habitación> listHabitacion = new List<Habitación>();
        int numero = 5020;
        bool disponibilidad = true;
        string disponible = "Disponible";
        string noDisponible = "No disponible";
        //Atributos
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponibilidad { get; set; }
        public string ClienteAsignado { get; set; }
        public  bool jacuzzi { get; set; }
        //Método constructor
        public Habitación(int numero, double precioPorNoche, bool disponibilidad, string clienteAsignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponibilidad = disponibilidad;
            ClienteAsignado = clienteAsignado;
        }
        //Métodos
        public void AgregarHabitacion()
        {
            Console.Write("Ingrese la cantidad de habitaciones que quiere registrar: ");
            int cantidad = int.Parse(Console.ReadLine());
            for (int i = 0; i < cantidad; i++)
            {
                numero += 1;
                Console.Write("Ingrese el precio por noche de la habitación: Q");
                double precioPorNoche = double.Parse(Console.ReadLine());
                Console.WriteLine("¿La habitación tiene jacuzzi? 1.Si/2.No");
                int jacuzzi = int.Parse(Console.ReadLine());
                if (jacuzzi == 1)
                {
                    listHabitacion.Add(new Habitación(numero,precioPorNoche, disponibilidad, null));
                }
                else if (jacuzzi == 2)
                {
                    listHabitacion.Add(new Habitación(numero, precioPorNoche, disponibilidad,null));
                }
            }
            Console.Clear();
            Console.WriteLine("Habitaciones registradas correctamente.");
            Console.WriteLine("Presione cualquier tecla para continuar: ");
        }
        public void MostrarInformacion()
        {
            Console.WriteLine("Información de las habitaciones: ");
            foreach (Habitación habitacion in listHabitacion)
            {
                Console.WriteLine($"Número de habitación: {habitacion.Numero}");
                Console.WriteLine($"Número de habitación: {habitacion.PrecioPorNoche}");
                Console.WriteLine($"Número de habitación: {habitacion.Disponibilidad}");
                Console.WriteLine($"Número de habitación: {habitacion.ClienteAsignado}");
            }
        }
    }
}
