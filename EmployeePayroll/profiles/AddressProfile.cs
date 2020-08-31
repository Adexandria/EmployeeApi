using AutoMapper;
using EmployeePayroll.Entities;
using EmployeePayroll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.profiles
{
    public class AddressProfile :Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressCreation,Address>().ForMember(dest => dest.HomeAddressId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Address1, opt => opt.MapFrom(src => src.Address1))
                .ForMember(dest => dest.Address2, opt => opt.MapFrom(src => src.Address2))
                .ForMember(dest => dest.PostalCode, opt => opt.MapFrom(src => src.PostalCode))
                .ForMember(dest => dest.City, opt => opt.MapFrom(src => src.City))
                .ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
                .ForMember(dest => dest.Region, opt => opt.MapFrom(src => src.Region));
         
            CreateMap<Address,EmployeeModel>()
                 .ForPath(dest => dest.Address.Id, opt => opt.MapFrom(src => src.HomeAddressId))
                .ForPath(dest => dest.Address.Address1, opt => opt.MapFrom(src => src.Address1))
                .ForPath(dest => dest.Address.Address2, opt => opt.MapFrom(src => src.Address2))
                .ForPath(dest => dest.Address.City, opt => opt.MapFrom(src => src.City))
                .ForPath(dest => dest.Address.Region, opt => opt.MapFrom(src => src.Region))
                .ForPath(dest => dest.Address.Country, opt => opt.MapFrom(src => src.Country))
                .ForPath(dest => dest.Address.PostalCode, opt => opt.MapFrom(src => src.PostalCode));

        }
    }
}
