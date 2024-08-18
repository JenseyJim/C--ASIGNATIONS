//2)	Crear un programa que cuente cuántos números, de un conjunto de 10, son divisibles por 3 o por 5.

try
{
    int num = 0;
    int cont = 0;

    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Ingrese el numero " + i + ": ");
        num = int.Parse(Console.ReadLine());



        if (num %3==0 || num % 5 == 0)
        {
           cont = cont + 1;
        }
        Console.WriteLine(" ");


    }
    Console.WriteLine("La cantidad de numeros div entre 3 o 5 son: " + cont);

}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
}
Console.ReadKey();