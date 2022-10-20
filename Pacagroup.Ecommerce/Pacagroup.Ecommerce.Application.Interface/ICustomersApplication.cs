using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Transversal.Common;

namespace Pacagroup.Ecommerce.Application.Interface
{
    public interface ICustomersApplication
    {
        #region Metodos Sincronos
        Response<bool> Insert(CustomersDto customersDto);

        Response<bool> Update(CustomersDto customersDto);

        Response<bool> Delete(string customersId);

        Response<CustomersDto> GetById(string customersId);

        Response<IEnumerable<CustomersDto>> GetAll();

        ResponsePagination<IEnumerable<CustomersDto>> GetAllWithPagination(int pageNumber, int pageSize);
        #endregion

        #region Metodos Asincronos
        Task<Response<bool>> InsertAsync(CustomersDto customersDto);

        Task<Response<bool>> UpdateAsync(CustomersDto customersDto);

        Task<Response<bool>> DeleteAsync(string customersId);

        Task<Response<CustomersDto>> GetByIdAsync(string customersId);

        Task<Response<IEnumerable<CustomersDto>>> GetAllAsync();

        Task<ResponsePagination<IEnumerable<CustomersDto>>> GetAllWithPaginationAsync(int pageNumber, int pageSize);
        #endregion
    }
}
