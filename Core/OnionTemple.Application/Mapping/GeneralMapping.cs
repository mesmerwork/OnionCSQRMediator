using AutoMapper;
using OnionTemplateEx.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionTemplateEx.Application.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<CountryDto,Domain.Entities.CountryEntity>().ReverseMap();
            CreateMap<CustomerDto,Domain.Entities.CustomerEntity>().ReverseMap();
            CreateMap<EmployeeDto,Domain.Entities.EmployeeEntity>().ReverseMap();
            CreateMap<OfficeDto,Domain.Entities.OfficeEntity>().ReverseMap();
            CreateMap<PaymentDto,Domain.Entities.PaymentEntity>().ReverseMap();
            CreateMap<UserDto,Domain.Entities.UserEntity >().ReverseMap();
        }
    }
}
