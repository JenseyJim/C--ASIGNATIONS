//Escribe un programa que cree una matriz de 20 elementos de tipo entero e
//inicialice cada uno de los elementos con un valor igual al índice del elemento multiplicado por 5.
//Imprime los elementos en la consola.

using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] matriz = CrearMatriz();
            ImprimirMatriz(matriz);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrio un error: " + ex.Message);
        }
        Console.ReadKey();
    }

    static int[] CrearMatriz()
    {
        int[] matriz = new int[20];
        for (int i = 0; i < matriz.Length; i++)
        {
            matriz[i] = i * 5;
        }
        return matriz;
    }

    static void ImprimirMatriz(int[] matriz)
    {
        foreach (int elemento in matriz)
        {
            Console.WriteLine(elemento);
        }
    }
}
