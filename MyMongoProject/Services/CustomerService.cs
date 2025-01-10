using AutoMapper;
using MongoDB.Driver;
using MyMongoProject.Dtos;
using MyMongoProject.Entities;
using MyMongoProject.Settings;

namespace MyMongoProject.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMongoCollection<Customer> _customerCollection;
        private readonly IMapper _mapper;

        public CustomerService(IMapper mapper, IDatabaseSettings _databaseSettings)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _customerCollection = database.GetCollection<Customer>(_databaseSettings.CustomerCollectionName);
            _mapper = mapper;
        }

        public async Task CreateCustomerAsync(CreateCustomerDto createCustomerDto)
        {
            var value = _mapper.Map<Customer>(createCustomerDto);
            await _customerCollection.InsertOneAsync(value);
        }

        public Task DeleteCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCustomerDto>> GetAllCustomerAsync()
        {
            throw new NotImplementedException();
        }

        public Task GetByIdCustomerAsync(string customerId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto)
        {
            throw new NotImplementedException();
        }
    }
}
