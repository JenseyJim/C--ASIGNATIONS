using System;

/*Crea una clase Alumno con las propiedades Nombre, Matricula, Carrera y Calificaciones (una lista de enteros).

Implementa un método CalcularPromedio que devuelva el promedio de las calificaciones.
Implementa un método MostrarInformacion que imprima el nombre, la matrícula, la carrera y el promedio del alumno
Crea instancias de la clase Alumno, asigna valores a las propiedades y muestra la información. */
public class Alumno
{
    String nombre;
    String matricula;
    String carrera;
    int promedio = 0;
    int suma = 0;

    List<int> calificaciones = new List<int>();
    
    public void calcularPromedio(List<int> calificaciones)
    {
        suma = calificaciones.Sum();
        promedio = suma / calificaciones.Count;
    }
    public void mostrarInformacion(String nombre, String matricula, String carrera)
    {
        Console.WriteLine("-----------INFO-----------");

        Console.WriteLine("El nombre del alumno es: " + nombre);
        Console.WriteLine("Matricula: " + matricula);
        Console.WriteLine("Carrera: " + carrera);
        Console.WriteLine("El Promedio es: " + promedio);
    }
}
