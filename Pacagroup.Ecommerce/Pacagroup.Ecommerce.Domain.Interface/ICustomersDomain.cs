using Pacagroup.Ecommerce.Domain.Entity;

namespace Pacagroup.Ecommerce.Domain.Interface
{
    public interface ICustomersDomain
    {
        #region Metodos Sincronos
        bool Insert(Customers customers);

        bool Update(Customers customers);

        bool Delete(string customersId);

        Customers GetById(string customersId);

        IEnumerable<Customers> GetAll();

        IEnumerable<Customers> GetAllWithPagination(int pageNumber, int pageSize);
        int Count();



        #endregion

        #region Metodos Asincronos
        Task<bool> InsertAsync(Customers customers);

        Task<bool> UpdateAsync(Customers customers);

        Task<bool> DeleteAsync(string customersId);

        Task<Customers> GetByIdAsync(string customersId);

        Task<IEnumerable<Customers>> GetAllAsync();

        Task<IEnumerable<Customers>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        Task<int> CountAsync();

        #endregion
    }
}
