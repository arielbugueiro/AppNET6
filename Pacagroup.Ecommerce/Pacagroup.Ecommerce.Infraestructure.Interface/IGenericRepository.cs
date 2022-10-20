using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Infrastructure.Interface
{
    //Interfaz generica <T>, reestriccion para que T siempre sea una clase
    public interface IGenericRepository<T> where T : class
    {
        #region Métodos Síncronos

        bool Insert(T entity);
        bool Update(T entity);
        bool Delete(string id);

        T GetById(string id);
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAllWithPagination(int pageNumber, int pageSize);
        int Count();

        #endregion

        #region Métodos Asíncronos
        Task<bool> InsertAsync(T entity);
        Task<bool> UpdateAsync(T entity);
        Task<bool> DeleteAsync(string id);

        Task<T> GetByIdAsync(string id);
        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<Customers>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        Task<int> CountAsync();
        #endregion
    }
}
