//Paso de arreglos por valor y por referencia

void ModifyArray(int[] arr)
{
    arr[0] = 99;
}

int[] myArray = { 1, 2, 3, 4 };
ModifyArray(myArray);
Console.WriteLine(myArray[0]); // Imprime 99

Console.ReadKey();
