using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    class Nerea
    {
        public string mote { get; set; }
        public int nivel_de_sexy { get; set; }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Mote: {mote}\nNivel de sexy: {nivel_de_sexy}");

        }
    }
    class Pareja
    {
        public string mote { get; set; }
        public int nivel_de_sexy { get; set; }

        public void MostrarAtributos()
        {
            Console.WriteLine($"Mote: {mote}\nNivel de sexy: {nivel_de_sexy}");

        }
    }
}
