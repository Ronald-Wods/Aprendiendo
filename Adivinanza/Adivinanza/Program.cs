//Idea: El usuario pone una palabra, si la pone bien se cierra el programa, si la pone mal, le da una pista y deja  probar otra vez.

using System;

class Program
{
    static void Main()
    {
        Principal();
    }

    private static void Principal()
    { 
       int intentos = 0;
       bool correcto = false;
        Console.WriteLine("Adivina la palabra, tiene 4 letras");

        do
        {
            string palabra = Console.ReadLine().ToUpper();

            if(palabra == "LAGO")
            {
                Console.WriteLine("\nMuy bien");
                correcto = true;
            }

            else
            {
                Console.WriteLine("\nNUH UH, inténtalo otra vez");
                intentos++;
            }

            if(intentos >= 1 && !correcto)
            {
                Pista1();
            }

            if (intentos >= 2 && !correcto)
            {
                Pista2();
            }



        } while (!correcto);

    }

    private static void Pista1()
    {
        Console.WriteLine("\nPista: La palabra empieza por L");
    }

    private static void Pista2()
    {
        Console.WriteLine("\nPista: La palabra acaba en O");
    }
   

}



