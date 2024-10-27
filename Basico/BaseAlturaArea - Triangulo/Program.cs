/*Desarrollar programa que calcule la base, altura y área de un triangulo
Diseñar un algoritmo que:
•	Solicite al usuario ingresar un número entero "n" que represente la cantidad de triángulos a procesar.
o	Para cada triángulo, capture los valores de la base y la altura.
o	Calcule el área de cada triángulo utilizando la fórmula correspondiente.
o	Muestre en pantalla los datos de cada triángulo (base, altura y área).
o	Determine y reporte la cantidad de triángulos con un área superior a 12 unidades cuadradas.

 */

using System;

class TrianguloAreaCalculator
{
    static void Main(string[] args)
    {
        int cantidadTriangulos = SolicitarCantidadTriangulos();
        ProcesarTriangulos(cantidadTriangulos);
        Console.ReadKey();
    }
     static int SolicitarCantidadTriangulos()
    {
        int n = 0;

        try
        {
            Console.Write("Ingrese la cantidad de triangulos a procesar: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Debe ingresar un numero entero positivo.");
                n = SolicitarCantidadTriangulos();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
            n = SolicitarCantidadTriangulos();
        }

        return n;
    }

    static void ProcesarTriangulos(int cantidadTriangulos)
    {
        int contadorTriangulosGrandes = 0;

        for (int i = 1; i <= cantidadTriangulos; i++)
        {
            try
            {
                Console.WriteLine($"\nTriangulo {i}:");
                double baseTriangulo = SolicitarValor("base");
                double alturaTriangulo = SolicitarValor("altura");

                double area = CalcularArea(baseTriangulo, alturaTriangulo);
                MostrarResultados(baseTriangulo, alturaTriangulo, area);

                if (area > 12)
                {
                    contadorTriangulosGrandes++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en la entrada. Por favor, ingrese un valor numérico valido.");
                i--; 
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrió un error inesperado: " + e.Message);
            }
        }

        Console.WriteLine($"\nCantidad de triangulos con un area superior a 12 unidades cuadradas: {contadorTriangulosGrandes}");
    }

    static double SolicitarValor(string tipo)
    {
        Console.Write($"Ingrese el valor de la {tipo}: ");
        return double.Parse(Console.ReadLine());
    }

    static double CalcularArea(double baseTriangulo, double alturaTriangulo)
    {
        return (baseTriangulo * alturaTriangulo) / 2;
    }

    static void MostrarResultados(double baseTriangulo, double alturaTriangulo, double area)
    {
        Console.WriteLine($"Base: {baseTriangulo}");
        Console.WriteLine($"Altura: {alturaTriangulo}");
        Console.WriteLine($"Area: {area} unidades cuadradas");
    }
    
}

