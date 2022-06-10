using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete
    {
        public decimal Peso { get; set; }
        public int Numero { get; set; }
        public string CiudadOrigen { get; set; }
        public Paquete() { }
        public Paquete(decimal peso, int numero, string ciudad)
        {
            this.Peso = peso;
            this.Numero = numero;
            this.CiudadOrigen = ciudad;
        }
    }
}
