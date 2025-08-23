Console.WriteLine("Método 1: Variables fijas");

string Nombre1 = "Mike";
int Edad1 = 24;
string Address1 = "Whitechapel, London";

Console.WriteLine($"\nUsuario: \"{Nombre1}\"\nEdad: \"{Edad1}\"\nDirección: \"{Address1}\"");

Console.WriteLine($"__________________________________");

Console.WriteLine("\nMétodo 2: Consola"); 

Console.WriteLine("\nPara registrarse siga las siguientes indicaciones:");
Console.WriteLine("\nProporcione su nombre");
string nombre2 = Console.ReadLine();

Console.WriteLine("\nProporcione su edad");
int edad2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nProporcione su dirección");
string address2 = Console.ReadLine();

Console.WriteLine("\nBienvenido");
Console.WriteLine($"\nUsuario: \"{nombre2}\"\nEdad: \"{edad2}\"\nDirección: \"{address2}\"");






