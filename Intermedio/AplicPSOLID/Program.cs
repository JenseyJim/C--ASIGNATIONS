using AplicPSOLID;
using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        var studentRepository = new StudentRepository();
        var subscriptionService = new SubscriptionService();
        var studentFactory = new StudentFactory();
        var courseFactory = new CourseFactory();
        Student student = null;

        while (true)
        {
            Console.WriteLine(" ");
            Console.WriteLine("1. Crear Estudiante");
            Console.WriteLine("2. Eliminar Estudiante");
            Console.WriteLine("3. Suscribir Estudiante a Curso");
            Console.WriteLine("4. Mostrar Estudiante y Cursos Suscritos");
            Console.WriteLine("5. Salir");
            Console.Write("Seleccione una opción: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    student = studentFactory.CreateStudent();
                    studentRepository.Save(student);
                    Console.WriteLine("Estudiante creado y guardado.");
                    break;
                case 2:
                    if (student != null)
                    {
                        studentRepository.Delete(student);
                        Console.WriteLine("Estudiante eliminado.");
                        student = null;
                    }
                    else
                    {
                        Console.WriteLine("No hay ningún estudiante para eliminar.");
                    }
                    break;
                case 3:
                    if (student != null)
                    {
                        var course = courseFactory.CreateCourse();
                        subscriptionService.Subscribe(student, course);
                        Console.WriteLine($"Estudiante suscrito al curso {course.Name}");
                    }
                    else
                    {
                        Console.WriteLine("Primero debe crear un estudiante.");
                    }
                    break;
                case 4:
                    if (student != null)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine($"ID: {student.StudentId}, Nombre: {student.FirstName} {student.LastName}");
                        Console.WriteLine("Cursos suscritos:");
                        foreach (var course in student.Courses)
                        {
                            Console.WriteLine($"- {course.Name} ({course.Type})");
                            Console.WriteLine(" ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay ningún estudiante creado.");
                    }
                    break;
                case 5:
                    Console.WriteLine("Saliendo del programa...");
                    return;
                default:
                    Console.WriteLine("Opción inválida. Intente de nuevo.");
                    break;
            }
        }
    }
}

