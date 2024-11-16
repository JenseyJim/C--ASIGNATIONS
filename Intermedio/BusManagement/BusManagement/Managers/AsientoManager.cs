using BusManagement.Entities;
using BusManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement.Managers
{
    public class AsientoManager
    {
        private AsientoRepository _repository;

        public AsientoManager(AsientoRepository repository)
        {
            _repository = repository;
        }

        public void AgregarAsiento()
        {
            Console.WriteLine("Ingrese BusId:");
            int busId = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese NumeroPiso:");
            int numeroPiso = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese NumeroAsiento:");
            int numeroAsiento = int.Parse(Console.ReadLine());

            Asiento asiento = new Asiento
            {
                BusId = busId,
                NumeroPiso = numeroPiso,
                NumeroAsiento = numeroAsiento,
                FechaCreacion = DateTime.Now
            };

            _repository.Agregar(asiento);
            Console.WriteLine("Asiento agregado con éxito.");
        }

        public void ActualizarAsiento()
        {
            Console.WriteLine("Ingrese Id del Asiento a actualizar:");
            int id = int.Parse(Console.ReadLine());

            Asiento asiento = _repository.ObtenerPorId(id);
            if (asiento != null)
            {
                Console.WriteLine("Ingrese nuevo BusId:");
                asiento.BusId = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nuevo NumeroPiso:");
                asiento.NumeroPiso = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese nuevo NumeroAsiento:");
                asiento.NumeroAsiento = int.Parse(Console.ReadLine());

                asiento.FechaCreacion = DateTime.Now;

                _repository.Actualizar(asiento);
                Console.WriteLine("Asiento actualizado con éxito.");
            }
            else
            {
                Console.WriteLine("Asiento no encontrado.");
            }
        }

        public void RemoverAsiento()
        {
            Console.WriteLine("Ingrese Id del Asiento a remover:");
            int id = int.Parse(Console.ReadLine());

            Asiento asiento = _repository.ObtenerPorId(id);
            if (asiento != null)
            {
                _repository.Remover(asiento);
                Console.WriteLine("Asiento removido con éxito.");
            }
            else
            {
                Console.WriteLine("Asiento no encontrado.");
            }
        }

        public void ListarTodosAsientos()
        {
            var asientos = _repository.TraerTodos();
            foreach (var asiento in asientos)
            {
                Console.WriteLine($"Id: {asiento.Id}, BusId: {asiento.BusId}, NumeroPiso: {asiento.NumeroPiso}, NumeroAsiento: {asiento.NumeroAsiento}, " +
                    $"FechaCreacion: {asiento.FechaCreacion}");
            }
        }

        public void ObtenerAsientoPorId()
        {
            Console.WriteLine("Ingrese Id del Asiento:");
            int id = int.Parse(Console.ReadLine());

            Asiento asiento = _repository.ObtenerPorId(id);
            if (asiento != null)
            {
                Console.WriteLine($"Id: {asiento.Id}, BusId: {asiento.BusId}, NumeroPiso: {asiento.NumeroPiso}, NumeroAsiento: {asiento.NumeroAsiento}, " +
                    $"FechaCreacion: {asiento.FechaCreacion}");
            }
            else
            {
                Console.WriteLine("Asiento no encontrado.");
            }
        }
    }
}
