using System;
using BusManagement.Context;
using BusManagement.Managers;
using BusManagement.Repository;

namespace BusManagment
{
    class Program
    {
        static void Main(string[] args)
        {
            DataContext context = new DataContext();
            AsientoRepository repository = new AsientoRepository(context);
            AsientoManager manager = new AsientoManager(repository);

            int option = 0;
            do
            {
                Console.WriteLine("\nSeleccione una opcion:");
                Console.WriteLine("1. Agregar Asiento");
                Console.WriteLine("2. Actualizar Asiento");
                Console.WriteLine("3. Remover Asiento");
                Console.WriteLine("4. Listar Todos los Asientos");
                Console.WriteLine("5. Obtener Asiento por ID");
                Console.WriteLine("6. Salir");

                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            manager.AgregarAsiento();
                            break;
                        case 2:
                            manager.ActualizarAsiento();
                            break;
                        case 3:
                            manager.RemoverAsiento();
                            break;
                        case 4:
                            manager.ListarTodosAsientos();
                            break;
                        case 5:
                            manager.ObtenerAsientoPorId();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo...");
                            break;
                        default:
                            Console.WriteLine("Opcion invalida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("ingrese un numero valido.");
                }

            } while (option != 6);
        }
    }
}

