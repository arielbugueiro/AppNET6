using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Pacagroup.Ecommerce.Application.DTO;
using Pacagroup.Ecommerce.Application.Interface;

namespace Pacagroup.Ecommerce.Services.WebApi.Controllers.v2
{
    [Authorize]
    //Forma de Estructurar la URI ejemplo -> https://localhost/api/Customers/Get
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    [ApiController]
    [ApiVersion("2.0")]
    public class CustomersController : Controller
    {
        private readonly ICustomersApplication _customersApplication;

        //Creamos un constructor para poder aplicar inyección de dependencias
        public CustomersController(ICustomersApplication customersApplication)
        {
            _customersApplication = customersApplication;
        }

        #region Métodos Síncronos
        [HttpPost]
        public IActionResult Insert([FromBody] CustomersDto customersDto)
        {
            if (customersDto == null)
                return BadRequest();
            var response = _customersApplication.Insert(customersDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }


        [HttpPut("Update/{customerId}")]
        public IActionResult Update(string customerId, [FromBody] CustomersDto customersDto)
        {
            var customerDto = _customersApplication.GetById(customerId);
            if (customerDto.Data == null)
                return NotFound(customerDto.Message);

            if (customersDto == null)
                return BadRequest();

            var response = _customersApplication.Update(customersDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpDelete("{customerId}")]
        public IActionResult Delete(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();
            var response = _customersApplication.Delete(customerId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpGet("{customerId}")]
        public IActionResult GetById(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();
            var response = _customersApplication.GetById(customerId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var response = _customersApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public IActionResult GetAllWithPagination([FromQuery] int pageNumber, int pageSize)
        {
            var response = _customersApplication.GetAllWithPagination(pageNumber, pageSize);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        #endregion

        #region Métodos Asíncronos

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] CustomersDto customersDto)
        {
            if (customersDto == null)
                return BadRequest();
            var response = await _customersApplication.InsertAsync(customersDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpPut("UpdateAsync/{customerId}")]
        public async Task<IActionResult> UpdateAsync(string customerId, [FromBody] CustomersDto customersDto)
        {
            var customerDto = await _customersApplication.GetByIdAsync(customerId);
            if (customerDto.Data == null)
                return NotFound(customerDto.Message);

            if (customersDto == null)
                return BadRequest();

            var response = await _customersApplication.UpdateAsync(customersDto);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpDelete("{customerId}")]
        public async Task<IActionResult> DeleteAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();
            var response = await _customersApplication.DeleteAsync(customerId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);

        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetByIdAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();
            var response = await _customersApplication.GetByIdAsync(customerId);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }


        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var response = await _customersApplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllWithPaginationAsync([FromQuery] int pageNumber, int pageSize)
        {
            var response = await _customersApplication.GetAllWithPaginationAsync(pageNumber, pageSize);
            if (response.IsSuccess)
                return Ok(response);

            return BadRequest(response.Message);
        }
        #endregion


    }
}
