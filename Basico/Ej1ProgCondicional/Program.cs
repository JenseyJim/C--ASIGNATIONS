/*
1)	Diseñar un programa que solicite al usuario dos números 
y, si el primer número es más grande, calcule y muestre su suma y resta. 
De lo contrario, calculará y mostrará su producto y cociente. */

int num1 = 0;
int num2 = 0;
string linea;

try
{
	Console.Write("Ingrese el numero 1: ");
	linea = Console.ReadLine();

	if (!int.TryParse (linea, out num1)){

		Console.WriteLine("Numero 1 Invalido");
		return;
	}
	else
	{
		num1 = Convert.ToInt32(linea);
	}

    Console.Write("Ingrese el numero 2: ");
    linea = Console.ReadLine();

    if (!int.TryParse(linea, out num2))
    {
        Console.WriteLine("Numero 2 Invalido");
        return;
    }
    else
    {
        num2 = Convert.ToInt32(linea);
    }

    if (num1 > num2) {

        int suma = num1 + num2;
        int resta = num1 - num2;

        Console.WriteLine("La suma es: " + suma);
        Console.WriteLine("La resta es: " + resta);
    }
    else
    {
        int producto = num1 * num2;
        int cociente = num1 / num2;

        Console.WriteLine("El Producto es: " + producto);
        Console.WriteLine("El Cociente es: " + cociente);
    }
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
	
}

