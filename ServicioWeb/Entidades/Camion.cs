using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camion
    {
        public int Numero { get; set; }
        public string Marca { get; set; }
        public DateTime FechaYHoraSalida { get; set; }
        public DateTime FechaYHoraDestino { get; set; }
        public decimal PesoMaximo { get; set; }
        public decimal PesoActual { get; set; }
        public Camion() { }

        public Camion(int numero, string marca, DateTime fechaYHoraDestino, decimal pesoMaximo)
        {
            Numero = numero;
            Marca = marca;
            FechaYHoraSalida = DateTime.Now;
            FechaYHoraDestino = fechaYHoraDestino;
            PesoMaximo = pesoMaximo;
        }    }
}
