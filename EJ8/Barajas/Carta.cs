using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ8.Barajas
{
    public class Carta
    {
        private string _tipoPalo;
        public int Numero { get; set; }
        public string Palo
        {
            get { return _tipoPalo; }
            set
            {
                if (value == "0")
                {
                    _tipoPalo = "Espadas";
                }
                else if (value == "1")
                {
                    _tipoPalo = "Bastos";
                }
                else if (value == "2")
                {
                    _tipoPalo = "Oros";
                }
                else if (value == "3")
                {
                    _tipoPalo = "Copas";
                }
            }
        }
    }
}