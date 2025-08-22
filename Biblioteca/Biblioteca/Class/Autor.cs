using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Class
{
    class Autor
    {
        private string Nombre;
        private string Apellido;

        public Autor(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;


        }
        //método
        public void MostrarDatos()
        {
            Console.WriteLine($" - Nombre: {Nombre} \n - Apellido: {Apellido}");
        }
    }
}
