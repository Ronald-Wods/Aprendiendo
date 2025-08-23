using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

class Program
{ 
    static void Main()
    {
        Menu();
    }

    static void Menu()
    { 
        bool exit = false;

        do
        {
            Console.WriteLine("\nEscribe \'1\' para proporcionar una oración o escribe \'2\' para acabar la sesión");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Mayus();
                    break;

                case 2:
                    Console.WriteLine("\nFin de la sesión");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("\nERROR: Opción desconocida, íntentalo de nuevo");
                    break;
            }

        } while (!exit);

    }

    private static void Mayus()
    {
        Console.WriteLine("\nA continuación, escribe una oración para poder pasarla a mayúsculas");
        string sentence = Console.ReadLine().ToUpper();

        Console.WriteLine($"\nAquí tiene su oración: \"{sentence}\"");

        
    }

}
       
                


                        

            

            
                



    


