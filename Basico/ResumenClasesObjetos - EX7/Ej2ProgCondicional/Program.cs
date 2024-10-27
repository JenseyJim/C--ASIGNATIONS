/* 2)	Leer tres calificaciones y calcular el promedio. 
 * Si el promedio es igual o superior a siete, imprimir un mensaje indicando que el alumno ha aprobado. */

int num1 = 0;
int num2 = 0;
int num3 = 0;

string linea;

try
{
    Console.Write("Ingrese el Calificacion 1: ");
    linea = Console.ReadLine();

    if (!int.TryParse(linea, out num1))
    {

        Console.WriteLine("Numero 1 Invalido");
        return;
    }
    else
    {
        num1 = Convert.ToInt32(linea);
    }

    Console.Write("Ingrese el Calificacion 2: ");
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

    Console.Write("Ingrese el Calificacion 3: ");
    linea = Console.ReadLine();

    if (!int.TryParse(linea, out num3))
    {
        Console.WriteLine("Numero 3 Invalido");
        return;
    }
    else
    {
        num3 = Convert.ToInt32(linea);
    }

    int suma = num1 + num2 + num3;
    int promedio = suma / 3;
    Console.WriteLine("PROMEDIO = " + promedio);
    /////////////
    if (promedio >= 7)
    {
        Console.WriteLine("Usted ha aprobado");
    }
    else
    {
        Console.WriteLine("Usted ha reprobado");
    }
    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");

}
