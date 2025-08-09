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
       int intentos = 3;
       bool correcto = false;
       bool incorrecto = false;
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
                intentos--;
                Console.WriteLine($"\nNUH UH, inténtalo otra vez, te quedan {intentos} intentos");
            }

            if (intentos == 0)
            {
                Console.WriteLine("Muy mal, la palabra era: Lago");
                incorrecto = true;
            }

            if(intentos <= 2 && !correcto && !incorrecto)
            {
                Pista1();
            }

            if (intentos == 1 && !correcto && !incorrecto)
            {
                Pista2();
            }



        } while (!correcto && !incorrecto);

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



