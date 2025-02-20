using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    private static bool continuar = true;

    static void Main()
    {
        while (continuar)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Ingresa 10 números:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Número {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (numeros[i] > numeros[j])
                    {
                        int temp = numeros[i];
                        numeros[i] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }

            Console.WriteLine("\nLos números ordenados son:");
            foreach (int numero in numeros)
            {
                Console.Write(numero + " ");
            }

            Console.WriteLine("\n¿Quieres ingresar otro conjunto de números? (s/n)");
            string respuesta = Console.ReadLine().ToLower();
            if (respuesta != "s")
            {
                continuar = false;
            }
            else
            {
                Console.Clear();
            }
        }

        Console.WriteLine("¡Gracias por usar el programa!");
    }
}