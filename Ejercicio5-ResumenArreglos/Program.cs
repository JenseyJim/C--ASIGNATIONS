// Paso de arreglos y elementos de arreglos a los métodos

void PrintArray(int[] arr)
{
    foreach (int item in arr)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int[] myArray = { 10, 20, 30, 40 };
PrintArray(myArray);
Console.ReadKey();
