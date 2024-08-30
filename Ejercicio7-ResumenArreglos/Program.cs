using System;

class LibroCalificaciones
{
    private int[] calificaciones;

    public LibroCalificaciones(int[] calificaciones)
    {
        this.calificaciones = calificaciones;
    }

    public void MostrarCalificaciones()
    {
        Console.WriteLine("Las calificaciones son: ");
        foreach (int calificacion in calificaciones)
        {
            Console.Write(calificacion + " ");
        }
        Console.WriteLine();
    }

    public void OrdenarCalificaciones()
    {
        Array.Sort(calificaciones);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int[] calificacionesEstudiantes = { 87, 68, 94, 100, 83, 78, 85, 91, 76, 87 };
        LibroCalificaciones miLibro = new LibroCalificaciones(calificacionesEstudiantes);

        miLibro.MostrarCalificaciones();
        miLibro.OrdenarCalificaciones();
        miLibro.MostrarCalificaciones(); // Ahora estarán ordenadas

        Console.ReadKey();
    }
}
