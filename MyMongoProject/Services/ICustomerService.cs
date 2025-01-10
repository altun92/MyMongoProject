using MyMongoProject.Dtos;

namespace MyMongoProject.Services
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(string customerId);
        Task GetByIdCustomerAsync (string customerId);
    }
}
