// la clase LibroCalificaciones que usa un arreglo rectangular

using System;

class LibroCalificaciones
{
    private int[,] calificaciones;

    public LibroCalificaciones(int[,] calificaciones)
    {
        this.calificaciones = calificaciones;
    }

    public void MostrarCalificaciones()
    {
        Console.WriteLine("Las calificaciones por examen son: ");
        for (int i = 0; i < calificaciones.GetLength(0); i++)
        {
            for (int j = 0; j < calificaciones.GetLength(1); j++)
            {
                Console.Write(calificaciones[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[,] calificacionesEstudiantes = { { 87, 96, 70 }, { 68, 87, 90 }, { 94, 100, 90 } };
        LibroCalificaciones miLibro = new LibroCalificaciones(calificacionesEstudiantes);
        miLibro.MostrarCalificaciones();
        Console.ReadKey();
    }
}

