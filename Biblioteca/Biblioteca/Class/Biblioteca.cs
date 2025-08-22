using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca.Class
{
    class Biblioteca
    {
        List <Libro> ListaLibros;

        public Biblioteca()
        {
           ListaLibros = new List<Libro> {};


        }
        public void AddLibro(Libro Livre)                        
        {
            ListaLibros.Add(Livre);

        }
        public int CountLibros() { return ListaLibros.Count; }
    }
}
