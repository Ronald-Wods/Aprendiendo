bool correcto = false;
Console.WriteLine("Adivina la palabra, aquí una pista: empieza por L");

do
{
    string palabra = Console.ReadLine().ToUpper();

    if(palabra == "LAGO")
    {
        Console.WriteLine("Muy bien");
        correcto = true;

    }

    else
    {
        Console.WriteLine("NUH UH, inténtalo otra vez");

    }

} while (!correcto);

