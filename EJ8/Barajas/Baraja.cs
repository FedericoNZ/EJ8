using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8.Barajas
{
    public class Baraja
    {
        public List<Carta> listaCartas { get; set; }
 
        public void Barajar()
        {
            if (listaCartas.Count == 0)
            {
                Console.WriteLine("\n========================================\nNo hay cartas disponibles para barajar.\n========================================\n");
            }
            else
            {
            int posicion;
            Random random = new Random();
                for (int i = 0; i < 80; i++)
                {
                    posicion = random.Next(listaCartas.Count);
                    listaCartas.Insert(posicion, listaCartas[0]);
                    listaCartas.Remove(listaCartas[0]);
                }
                 Console.WriteLine("\n======================\nCARTAS BARAJADAS.\n======================\n");
            }
        }
        public Carta SiguienteCarta()
        {
            if(listaCartas.Count == 0)
            {
                return null;
            }
            else
            {
                Carta SCarta = new Carta();
                SCarta = listaCartas[0];
                listaCartas.Remove(listaCartas[0]);
                return SCarta;
            } 
        }
        public int CartasDisponibles()
        {
            return listaCartas.Count;
        }
        public List<Carta> DarCartas(int cantidad)
        {
            if(cantidad <= listaCartas.Count && cantidad > 0)
            {
                List<Carta> DarCartas = new List<Carta>();
                for (int i = 0; i < cantidad; i++)
                {
                    DarCartas.Add(listaCartas[0]);
                    listaCartas.Remove(listaCartas[0]);
                }
                return DarCartas;
            }
            else
            {
                return null;
            }
        }
        public void CartasMonton()
        {
            if (listaCartas.Count == 0) Console.WriteLine("No hay cartas en el montón.");
            foreach (var n in listaCartas)
            {
                Console.WriteLine($"{n.Numero} de {n.Palo}");
            }
        }
        public void MostrarBaraja()
        {
            if (listaCartas.Count == 0) Console.WriteLine("No hay cartas disponibles.");
            foreach (var n in listaCartas)
            {
                Console.WriteLine($"{n.Numero} de {n.Palo}");
            }
        }
    }
}
