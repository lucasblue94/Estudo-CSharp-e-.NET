using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploConstrutores.Models
{
    internal class Matematica
    {
        public int x { get; set; }
        public int y { get; set; }

        public Matematica(int x, int y)
        {
            this.x = x;
            this.y = y;

            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(x, y);
        }

        public void EventHandler ()
        {
            Console.WriteLine("Metódo executado");
        }
    }
}
