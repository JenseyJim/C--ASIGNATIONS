/*Programa array 3
Crear un programa que solicite al usuario "N" números, almacenarlos en una estructura de datos lineal y determinar lo siguiente:

El menor valor. 
Indicar si algún valor se repite al menos una vez*/

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            List<int> numeros = LeerNumeros();
            int menorValor = ObtenerMenorValor(numeros);
            bool algunValorRepetido = VerificarRepetidos(numeros);

            Console.WriteLine("El menor valor es: " + menorValor);
            Console.WriteLine(algunValorRepetido ? "Hay al menos un valor repetido" : "No hay valores repetidos");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrio un error: " + ex.Message);
        }
        Console.ReadKey();
    }

    static List<int> LeerNumeros()
    {
        List<int> numeros = new List<int>();
        Console.WriteLine("Introduce la cantidad de numeros:");
        int cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"Introduce el numero {i + 1}:");
            numeros.Add(int.Parse(Console.ReadLine()));
        }

        return numeros;
    }

    static int ObtenerMenorValor(List<int> numeros)
    {
        return numeros.Min();
    }

    static bool VerificarRepetidos(List<int> numeros)
    {
        return numeros.GroupBy(n => n).Any(g => g.Count() > 1);
    }
}

