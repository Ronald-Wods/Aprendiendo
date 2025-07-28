using System.ComponentModel.Design;

class Program
{

    static void Main()
    {
        Menu();

    }
    private static void Menu()
    {
        bool exit = false;

        do
        {
            Console.WriteLine("\n-----------------\n");
            Console.WriteLine("\nElige que hacer con los números:");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.WriteLine("\tx - Salir");

            switch (Console.ReadLine())
            {
                case "s":
                    Sumar();
                    break;

                case "r":
                    Restar();
                    break;

                case "m":
                    Multiplicar();
                    break;

                case "d":
                    Dividir();
                    break;

                case "x":
                    Console.WriteLine("\nBye");
                    exit = true;
                    break;

                default:
                    Console.WriteLine("\nPor favor escoja una de las opciones disponibles");
                    break;
            }
        } while (!exit);


    }
    private static void Sumar()
    {
        int num1;
        int num2;
        
        Console.WriteLine("Sumar\r");
        Console.WriteLine("-----------------\n");     
        
        Console.WriteLine("\nElige un número y pulsa enter");
        num1 = Convert.ToInt32(Console.ReadLine());
      
        Console.WriteLine("\nElige otro número y pulsa enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTu resultado: {num1} + {num2} = " + (num1 + num2));
    }
    private static void Restar()
    {
        int num1;
        int num2;

        Console.WriteLine("Restar\r");
        Console.WriteLine("-----------------\n");

        Console.WriteLine("\nElige un número y pulsa enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nElige otro número y pulsa enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTu resultado: {num1} - {num2} = " + (num1 - num2));
    }
    private static void Multiplicar()
    {
        int num1;
        int num2;

        Console.WriteLine("Multiplicar\r");
        Console.WriteLine("-----------------\n");

        Console.WriteLine("\nElige un número y pulsa enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nElige otro número y pulsa enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTu resultado: {num1} * {num2} = " + (num1 * num2));
    }
    private static void Dividir()
    {
        int num1;
        int num2;

        Console.WriteLine("Dividir\r");
        Console.WriteLine("-----------------\n");

        Console.WriteLine("\nElige un número y pulsa enter");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nElige otro número y pulsa enter");
        num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nTu resultado: {num1} / {num2} = " + (num1 / num2));
    }
}


