/* 2) Crear un programa que cuente cuántas piezas de hierro de un lote, dentro de un rango específico de longitud, son aptas para fabricar perfiles. */

using System;
try
{
    int medida = 0;
    int cantidad = 0;
    int longitudMin = 0;
    int longitudMax = 0;
    int perfiles = 0;
    int cont = 1;

    Console.Write("Ingrese la cantidad de piezas de hierro en el lote: ");
    cantidad = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el rango minimo de longitud: ");
    longitudMin = int.Parse(Console.ReadLine());

    Console.Write("Ingrese el rango maximo de longitud: ");
    longitudMax = int.Parse(Console.ReadLine());

    while (cont <= cantidad)
    {
        Console.Write("Ingrese la longitud de la pieza de hierro : " + cont);
        medida = int.Parse(Console.ReadLine());
                
        if (medida >= longitudMin && medida <= longitudMax)
        {
            perfiles++;
        }
        cont++; 
    }

    Console.WriteLine(" ");
    Console.WriteLine("La cantidad de piezas aptas para fabricar perfiles es: " + perfiles);
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrió el siguiente error: {ex.Message}");
}
Console.ReadKey();
