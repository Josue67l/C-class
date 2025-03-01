using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu nombre: ");
        string nombre = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(nombre))
        {
            char inicial = nombre.Trim()[0];
            Console.WriteLine($"Tu inicial es: {inicial}");
        }
        else
        {
            Console.WriteLine("No ingresaste un nombre válido.");
        }
    }
}