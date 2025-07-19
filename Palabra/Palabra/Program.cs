bool correcto = false;

Console.WriteLine("Adivina la palabra, te doy una pista: Empieza por F");

do
{
    switch (Console.ReadLine())
    {
        case "flor":
            Console.WriteLine("Muy bien");
            correcto = true;
            break;
        case "Flor":
            Console.WriteLine("Muy bien");
            correcto = true;
            break;

        default:
            Console.WriteLine("NUH UH, inténtalo otra vez");
            break;
    }


} while (!correcto);
