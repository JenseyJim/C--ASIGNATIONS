using BusManagement.Context;
using BusManagement.Entities;
using BusManagement.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagement.Base
{
    public class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        protected DataContext _context;
        protected List<T> _entities;

        public BaseRepository(DataContext context)
        {
            _context = context;
            var property = _context.GetType().GetProperties()
                .FirstOrDefault(p => p.PropertyType == typeof(List<T>));

            if (property != null)
            {
                _entities = (List<T>)property.GetValue(_context);
            }
            else
            {
                _entities = new List<T>();
            }
        }

        public void Agregar(T entity)
        {
            entity.Id = _entities.Count > 0 ? _entities.Max(e => e.Id) + 1 : 1;
            _entities.Add(entity);
        }

        public void Actualizar(T entity)
        {
            var existingEntity = _entities.FirstOrDefault(e => e.Id == entity.Id);
            if (existingEntity != null)
            {
                var index = _entities.IndexOf(existingEntity);
                _entities[index] = entity;
            }
        }

        public void Remover(T entity)
        {
            _entities.Remove(entity);
        }

        public List<T> TraerTodos()
        {
            return _entities;
        }

        public T ObtenerPorId(int id)
        {
            return _entities.FirstOrDefault(e => e.Id == id);
        }
    }
}
