using POO;

class Progam
{
    static void Main()
    {
        Console.WriteLine("Mi amado:\n");
        Nerea pr = new Nerea();
        pr.mote = "Gatito";
        pr.nivel_de_sexy = 9000;
        pr.MostrarAtributos();


        Console.WriteLine("\nYo:\n");
        Pareja pr1 = new Pareja();
        pr1.mote = "Lobito";
        pr1.nivel_de_sexy = 8999;
        pr1.MostrarAtributos();

    }
}
