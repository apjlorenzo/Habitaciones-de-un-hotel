using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    public class Habitación
    {
        public List<Habitación> habitacion = new List<Habitación>();
        //Atributos
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public string Disponibilidad { get; set; }
        public string ClienteAsignado { get; set; }
        //Método constructor
        public Habitación(int numero, double precioPorNoche, string disponibilidad, string clienteAsignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponibilidad = disponibilidad;
            ClienteAsignado = clienteAsignado;
        }
        public void EliminarHabitacion()
        {
            Console.Write("Ingrese el numero de la habitacion que quiere eliminar: ");
            int numero = int.Parse(Console.ReadLine());
            Habitación encontrar = habitacion.Find(p => p.Numero == numero);
            if (encontrar != null)
            {
                habitacion.Remove(encontrar);
                Console.WriteLine("Se ha eliminado correctamente.");
                Console.WriteLine("\nPresione cualquier tecla para continuar: ");
            }
            else
            {
                Console.WriteLine("No hay ninguna habitacion con ese numero.");
            }
        }
    }
}
