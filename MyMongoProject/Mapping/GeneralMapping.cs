using AutoMapper;
using MyMongoProject.Dtos;
using MyMongoProject.Entities;

namespace MyMongoProject.Mapping
{
    public class GeneralMapping: Profile
    {
        public GeneralMapping()
        {
            CreateMap<Customer, CreateCustomerDto>().ReverseMap();    
            CreateMap<Customer, UpdateCustomerDto>().ReverseMap();    
            CreateMap<Customer, ResultCustomerDto>().ReverseMap();    
            CreateMap<Customer, GetByIdCustomerDto>().ReverseMap();    
        }
    }
}
