using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

class Program
{
    static void Main()
    {
        int opcion;
        double num1, num2, resultado;

        do
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicación");
            Console.WriteLine("4- División");
            Console.WriteLine("5- Elevar un número a la potencia");
            Console.WriteLine("6- Salir");
            Console.Write("Selecciona una opción (1-6): ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es: {resultado}");
                    break;

                case 2:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es: {resultado}");
                    break;

                case 3:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es: {resultado}");
                    break;

                case 4:
                    Console.Write("Ingresa el primer número: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el segundo número: ");
                    num2 = double.Parse(Console.ReadLine());

                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                        Console.WriteLine($"El resultado de la división es: {resultado}");
                    }
                    else
                    {
                        Console.WriteLine("Error: No se puede dividir por cero.");
                    }
                    break;

                case 5:
                    Console.Write("Ingresa el número base: ");
                    num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingresa el exponente: ");
                    num2 = double.Parse(Console.ReadLine());
                    resultado = Math.Pow(num1, num2);
                    Console.WriteLine($"El resultado de la potencia es: {resultado}");
                    break;

                case 6:
                    Console.WriteLine("¡Gracias por usar la calculadora! Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción inválida, por favor selecciona una opción entre 1 y 6.");
                    break;
            }

            if (opcion != 6)
            {
                Console.WriteLine("\nPresiona una tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }

        } while (opcion != 6);
    }
}
