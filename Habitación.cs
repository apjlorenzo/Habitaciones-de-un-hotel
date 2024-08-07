using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_02
{
    internal class Habitación
    {
        public List<Habitación> Habitacion;
        //Atributos
        public int Numero { get; set; }
        public double PrecioPorNoche { get; set; }
        public bool Disponibilidad { get; set; }
        public string ClienteAsignado { get; set; }
        //Método constructor
        public Habitación(int numero, double precioPorNoche, bool disponibilidad, string clienteAsignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponibilidad = disponibilidad;
            ClienteAsignado = clienteAsignado;
        }
        //Métodos
        public void MostrarInformacion()
        {

        }
    }
}
