//3.Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.

int num1 = 0;
int num2 = 0;
int num3 = 0;
int num4 = 0;

Console.Write("Ingrese el numero 1: ");
num1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero 2: ");
num2 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero 3: ");
num3 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el numero 4: ");
num4 = int.Parse(Console.ReadLine());

int suma = num1 + num2 + num3 + num4;
int promedio = suma / 4;

Console.WriteLine("La suma de ambos numeros es: " + suma);
Console.WriteLine("El Promedio de los numeros es: " + promedio);
Console.ReadKey();
