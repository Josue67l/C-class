using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

class Program
{
    static void Main()
    {
        DateTime hoy = DateTime.Today;
        DateTime primerDiaMes = new DateTime(hoy.Year, hoy.Month, 1);
        int diasEnMes = DateTime.DaysInMonth(hoy.Year, hoy.Month);
        int primerDiaSemana = (int)primerDiaMes.DayOfWeek;
        string nombreMes = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(hoy.Month);

        Console.WriteLine($"\n    {nombreMes} {hoy.Year}\n");
        Console.WriteLine("lu ma mi ju vi sá do");

        for (int i = 0; i < primerDiaSemana; i++)
        {
            Console.Write("   ");
        }

        for (int dia = 1; dia <= diasEnMes; dia++)
        {
            Console.Write($"{dia,2} ");

            if ((primerDiaSemana + dia) % 7 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}
