/* 3) Desarrollar un programa que calcule el nivel de un postulante a partir de los resultados de un test. 
 El programa recibirá como entrada el número total de preguntas y las respuestas correctas, y devolverá un nivel según el porcentaje de aciertos.
•	Nivel máximo: Porcentaje>=90%.
•	Nivel medio: Porcentaje>=75% y <90%.
•	Nivel regular: Porcentaje>=50% y <75%.
•	Fuera de nivel: Porcentaje<50%.
*/

using System.Timers;

float num1 = 0;
float num2 = 0;
string linea;

try
{
    Console.Write("Ingrese el numero total de preguntas: ");
    linea = Console.ReadLine();

    if (!float.TryParse(linea, out num1))
    {

        Console.WriteLine("Numero 1 Invalido");
        return;
    }
    else
    {
        num1 = Convert.ToInt32(linea);
    }

    Console.Write("Ingrese el numero total de respuestas acertadas: ");
    linea = Console.ReadLine();

    if (!float.TryParse(linea, out num2))
    {
        Console.WriteLine("Numero 2 Invalido");
        return;
    }
    else
    {
        num2 = Convert.ToInt32(linea);
    }

    float porcentajeAciertos = ((num2 / num1)*100);
    Console.WriteLine("El porcentaje de aciertos es: " + porcentajeAciertos + "%");


    if (porcentajeAciertos >= 90)
    {
        Console.WriteLine("NIVEL MAXIMO");
    }
    if (porcentajeAciertos >= 75 && porcentajeAciertos <90)
    {
        Console.WriteLine("NIVEL MEDIO");

    }
    if (porcentajeAciertos >= 50 && porcentajeAciertos < 75)
    {
        Console.WriteLine("NIVEL REGULAR");

    }
    if (porcentajeAciertos < 50)
    {
        Console.WriteLine("FUERA DE NIVEL");

    }

    Console.ReadKey();
}
catch (Exception ex)
{
    Console.WriteLine($"Ocurrio el siguiente error: {ex.Message}");

}