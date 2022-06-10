using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Principal
    {
        public static List<Camion> Camiones;
        public List<Paquete> Paquetes;
        public static Camion Alta (int numero, string marca, DateTime fechaDestino, decimal pesoMaximo)
        {
            if (pesoMaximo != 0)
            {
                Camion camion = new Camion(numero, marca, fechaDestino, pesoMaximo);
                Camiones.Add(camion);
                return camion;
            }
            return null;
        }
        public bool Baja (int numero)
        {
            if (Camiones.Exists(x => x.Numero == numero)) { Camiones.Remove(Camiones.Find(x => x.Numero == numero)); return true; }
            return false;
        }
        public Camion Modificacion(int numero, decimal pesoMaximo)
        {
            if (Camiones.Exists(x => x.Numero == numero))
            { if (Camiones.Find(x => x.Numero == numero).PesoActual >= pesoMaximo) {Camiones.Find(x => x.Numero == numero).PesoMaximo = pesoMaximo; return Camiones.Find(x => x.Numero == numero); } }
            return null;
        }
        public ReturAltaPaquete AltaPaquete (decimal peso, int numero, string ciudadOrigen)
        {
            if (peso != 0 && VerificarLugar(peso) != null)
            {
                Paquete paquete = new Paquete(peso, numero, ciudadOrigen);
                Paquetes.Add(paquete);
                return VerificarLugar(peso);
            }
            return null;
        }
        public ReturAltaPaquete VerificarLugar(decimal peso)
        {
            foreach (var item in Camiones)
            {
                if (item.PesoMaximo <= item.PesoActual + peso) { item.PesoActual += peso; return new ReturAltaPaquete() { FechaLlegada = item.FechaYHoraDestino, NumeroCamion = item.Numero}; }
            }
            return null;
        }
    }
}
