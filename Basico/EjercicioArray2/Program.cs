/*
Escriba un programa que lea dos matrices desde la consola y verifique si son iguales (dos matrices son iguales cuando tienen la misma longitud 
y todos sus elementos, que tienen el mismo índice, son iguales). */

using System;

class Program
{
    static void Main()
    {
        try
        {
            int[] matriz1 = LeerMatriz();
            int[] matriz2 = LeerMatriz();
            bool sonIguales = VerificarIgualdad(matriz1, matriz2);
            Console.WriteLine(sonIguales ? "Las matrices son iguales" : "Las matrices no son iguales");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrio un error: " + ex.Message);
        }
        Console.ReadKey();
    }

    static int[] LeerMatriz()
    {
        Console.WriteLine("Introduce la longitud de la matriz:");
        int longitud = int.Parse(Console.ReadLine());
        int[] matriz = new int[longitud];
        for (int i = 0; i < longitud; i++)
        {
            Console.WriteLine($"Introduce el elemento {i}:");
            matriz[i] = int.Parse(Console.ReadLine());
        }
        return matriz;
    }

    static bool VerificarIgualdad(int[] matriz1, int[] matriz2)
    {
        if (matriz1.Length != matriz2.Length) return false;

        for (int i = 0; i < matriz1.Length; i++)
        {
            if (matriz1[i] != matriz2[i]) return false;
        }

        return true;
    }
}

