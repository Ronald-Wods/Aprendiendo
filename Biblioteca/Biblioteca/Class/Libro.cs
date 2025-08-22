using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Biblioteca.Class
{
    class Libro
    {
        private string Título;
        private long ISBN;
        private Autor autor;

        public Libro(string título, long isbn, Autor author)
        {
            Título = título;
            ISBN = isbn;
            autor = author;



        }
        public void MostrarDatos()
        {
            Console.WriteLine($" - Título: {Título} \n - ISBN: {ISBN}");
            autor.MostrarDatos();
        }
        
        public string GetTítulo() { return Título; }
        public void AñadirAutor(Autor author) 
        {
            author = autor;
        }
    }
}
