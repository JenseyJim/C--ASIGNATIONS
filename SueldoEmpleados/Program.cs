/* Desarrollar programa que calcule el sueldo de los empleados
•	En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, 
realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300. 
Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
 */


using System;

class SueldosEmpleados
{
    static void Main(string[] args)
    {
        int cantidadEmpleados = SolicitarCantidadEmpleados();
        ProcesarSueldos(cantidadEmpleados);
        Console.ReadKey();
    }

    static int SolicitarCantidadEmpleados()
    {
        int n = 0;

        try
        {
            Console.Write("Ingrese la cantidad de empleados: ");
            n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Debe ingresar un numero entero positivo.");
                n = SolicitarCantidadEmpleados();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Entrada invalida. Por favor, ingrese un numero entero.");
            n = SolicitarCantidadEmpleados();
        }

        return n;
    }

    static void ProcesarSueldos(int cantidadEmpleados)
    {
        int empleados100a300 = 0;
        int empleadosMasDe300 = 0;
        double totalSueldos = 0;

        for (int i = 1; i <= cantidadEmpleados; i++)
        {
            try
            {
                double sueldo = SolicitarSueldo(i);
                totalSueldos += sueldo;

                if (sueldo >= 100 && sueldo <= 300)
                {
                    empleados100a300++;
                }
                else if (sueldo > 300)
                {
                    empleadosMasDe300++;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error en la entrada. Por favor, ingrese un valor numerico valido.");
                i--;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocurrio un error inesperado: " + e.Message);
            }
        }

        Console.WriteLine($"\nCantidad de empleados que cobran entre $100 y $300: {empleados100a300}");
        Console.WriteLine($"Cantidad de empleados que cobran mas de $300: {empleadosMasDe300}");
        Console.WriteLine($"El importe total que gasta la empresa en sueldos: ${totalSueldos}");
    }

    static double SolicitarSueldo(int empleadoNumero)
    {
        Console.Write($"Ingrese el sueldo del empleado {empleadoNumero}: ");
        double sueldo = double.Parse(Console.ReadLine());

        if (sueldo < 100 || sueldo > 500)
        {
            Console.WriteLine("El sueldo debe estar entre $100 y $500.");
            sueldo = SolicitarSueldo(empleadoNumero);
        }

        return sueldo;
    }
}
