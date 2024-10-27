// Listas de argumentos de longitud variable

void ImprimirValores(params int[] numeros)
{
    foreach (int num in numeros)
    {
        Console.Write(num + " ");
    }
    Console.WriteLine();
}

ImprimirValores(1, 2, 3, 4, 5);
ImprimirValores(10, 20);

Console.ReadKey();