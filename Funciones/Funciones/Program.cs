class Program
{
    static void Main()
    {
        Console.WriteLine("Buenas Tardes\n");
        Console.WriteLine("¿Qué tal estás?\n");
        string respuesta = Console.ReadLine();

        Pruebas(respuesta);
    }
    private static void Pruebas(string respuesta)
    {
        Console.WriteLine($"\n¿{respuesta}?");
    }
}