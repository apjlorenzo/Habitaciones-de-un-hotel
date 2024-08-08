using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    public class Habitación
    {
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
    }
}
