
//Switch time
    bool salir = false;
do
{
int num1;
int num2;
//Título
Console.WriteLine("Calcular\r");
Console.WriteLine("-----------------\n");
//Pedir número al usuario
Console.WriteLine("Elige un número y pulsa enter");
num1 = Convert.ToInt32(Console.ReadLine());
//Segundo número
Console.WriteLine("Elige otro número y pulsa enter");
num2 = Convert.ToInt32(Console.ReadLine());
//Opción matemática
Console.WriteLine("Elige que hacer con los números:");
Console.WriteLine("\ts - Sumar");
Console.WriteLine("\tr - Restar");
Console.WriteLine("\tm - Multiplicar");
Console.WriteLine("\td - Dividir");
Console.WriteLine("\tx - Salir");

    switch (Console.ReadLine())
    {
        case "s":
            Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
            break;
        case "r":
            Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
            break;
        case "m":
            Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
            break;
        case "d":
            Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
            break;
        case "x":
            Console.WriteLine("Bye");
            salir = true;
            break;

    }

} while (!salir);