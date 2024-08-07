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
        bool disponibilidad = true;
        //Atributos
        public int NumeroDeCamas { get; set; }
        //MétodoConstructos
        public HabitacionSimple(int numero, double precioPorNoche, bool disponibilidad, string clienteAsignado, int numeroDeCamas) : base(numero, precioPorNoche, disponibilidad, clienteAsignado)
        {
            Numero = numero;
            PrecioPorNoche = precioPorNoche;
            Disponibilidad = disponibilidad;
            ClienteAsignado = clienteAsignado;
            NumeroDeCamas = numeroDeCamas;

        }
        
    }
}
