// 1)	Dado un conjunto de datos representando las dimensiones de triángulos, calcular y contar aquellos cuya área excede un valor límite.

String linea;
float baseTriangulo = 0;
float altura = 0;
float area = 0;
int cont = 0;
try
{
    for (int i = 1; i <= 10; i++)
    {

        Console.Write("Ingrese base triangulo " + i + ": ");
        baseTriangulo = int.Parse(Console.ReadLine());

        Console.Write("Ingrese altura triangulo " + i + ": ");
        altura = int.Parse(Console.ReadLine());

        area = (baseTriangulo * altura) / 2;

        if (area >= 10)

        {
            Console.WriteLine("El area del triangulo " + i + " es: " + area);
            cont = cont + 1;
        }
        Console.WriteLine(" ");
    }

Console.WriteLine("La cantidad de triangulos que exceden el valor limite (10) son: " + cont);
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");
}

Console.ReadKey();