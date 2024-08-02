int num1 = 0;
int num2 = 0;

Console.Write("Ingrese el numero 1: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero 2: ");
num2 = int.Parse(Console.ReadLine());

int suma = num1 + num2;
int producto = num1 * num2;

Console.WriteLine("La suma de ambos numeros es: " + suma);
Console.WriteLine("El Producto de ambos numeros es: " + producto);
Console.ReadKey();
