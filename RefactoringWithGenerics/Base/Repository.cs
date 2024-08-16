using RefactoringWithGenerics.Entities;
using RefactoringWithGenerics.Interfaces;


namespace RefactoringWithGenerics.Base
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected List<T> entities = new List<T>();


        public void Agregar(T entity)
        {
            entities.Add(entity);
        }
        public void Actualizar(T entity) { 

                throw new KeyNotFoundException("La entidad a actualizar no fue encontrada");

        }
        public void Remover(T entity)
        {
            entities.Remove(entity);
        }

        public T ObtenerPorId(int id)
        {
            var idProperty = typeof(T).GetProperty("AsientoId");  /*se obtiene una representacion mediante la clase PropertyInfo de AsientoId en la Clase Asiento,
                                                                  luego */
            if (idProperty == null)
            {
                throw new ArgumentException("La entidad no tiene una propiedad Id.");
            }

            var entity = entities.FirstOrDefault(e => (int)idProperty.GetValue(e) == id);
            if (entity == null)
            {
                throw new KeyNotFoundException("La entidad con el ID especificado no se encontró.");
            }

            return entity;
        }
        public List<T> TraerTodos()
        {
            return entities;
        }
    }
}
