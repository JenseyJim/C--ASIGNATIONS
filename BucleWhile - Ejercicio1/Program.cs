/* 1)	Confeccionar un programa que, a partir de una secuencia de 10 números enteros, 
   calcule y muestre la suma y el promedio aritmético de dichos números. */


using System;
try
{
    int num = 0;
    int suma = 0;
    float promedioAritmetico = 0;
    int cont = 1;

    while (cont <= 10)
    {
        Console.Write("Ingrese el numero " + cont + ": ");
        num = int.Parse(Console.ReadLine());

        suma += num;
        promedioAritmetico = suma / 10;

        cont++;

    }
    Console.WriteLine(" ");
    Console.WriteLine("La suma es: " + suma);
    Console.WriteLine("El promedio es: " + promedioAritmetico);
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
}

Console.ReadKey();



