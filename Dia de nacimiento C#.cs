using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Introduce tu fecha de nacimiento (dd/mm/yyyy): ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fecha))
        {
            string diaSemana = fecha.ToString("dddd", new CultureInfo("es-ES"));
            Console.WriteLine($"Naciste un {diaSemana}.");
        }
        else
        {
            Console.WriteLine("Formato de fecha inválido.");
        }
    }
}
