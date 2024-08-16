

namespace RefactoringWithGenerics.Interfaces
{
    public interface IRepository<T> where T : class   //La interfaz o contrato solo recibe clases por parametro
    {
        void Agregar(T entity);
        void Actualizar(T entity);
        void Remover(T entity);
        List<T> TraerTodos();
        T ObtenerPorId(int id);
    }

}
