///2.Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
//Mostrar lo que debe abonar el comprador.

float precio = 0;
int cantidad = 0;

Console.Write("Ingrese el precio del articulo: ");
precio = float.Parse(Console.ReadLine());

Console.Write("Ingrese la cantidad de articulos que se llevara: ");
cantidad = int.Parse(Console.ReadLine());

int abonar = (int)(precio * cantidad);

Console.WriteLine("\nEl comprador debe abonar: $" + abonar + " Pesos");

Console.ReadKey();

