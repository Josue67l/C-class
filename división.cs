using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el primer número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
            else
            {
                double resultado = num1 / num2;
                Console.WriteLine($"El resultado de la división es: {resultado}");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese valores numéricos válidos.");
        }
    }
}
