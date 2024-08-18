// 3) Desarrollar un programa que permita ingresar 10 números y luego muestre la suma de los últimos 5 números ingresados.

try
{
    int num = 0;
    int cont = 0;
    int suma = 0;

    for (int i = 1; i <= 10; i++)
    {
        Console.Write("Ingrese el numero " + i + ": ");
        num = int.Parse(Console.ReadLine());
        
        if (i>5)
        {
            suma += num;
        }
       
    }
    Console.WriteLine("La suma de los ultimos 5 numeros ingresados es: " + suma);
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
}
Console.ReadKey();

