using AutoMapper;
using EmployeePayroll.Entities;
using EmployeePayroll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.profiles
{
    public class OpenProfile:Profile
    {
        public OpenProfile()
        {
            CreateMap<OpenCreation, OpenBalances>()
                .ForMember(dest => dest.OpenBalancesId, opt => opt.MapFrom(src => src.Id))
                .ForPath(dest => dest.LeaveLines.LeaveLinesId, opt => opt.MapFrom(src => src.LinesId))
                   .ForMember(dest => dest.Tax, opt => opt.MapFrom(src => src.Tax))
                   .ForMember(dest => dest.OpeningBalanceDate, opt => opt.MapFrom(src => src.OpeningBalanceDate));

            CreateMap<Employee, OpenCreation>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.OpenBalancesId));
            CreateMap<OpenBalances, OpenDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.OpenBalancesId))
                .ForPath(dest => dest.LeaveLines.LeaveLinesId, opt => opt.MapFrom(src => src.LeaveLines.LeaveLinesId))
                   .ForMember(dest => dest.Tax, opt => opt.MapFrom(src => src.Tax))
                   .ForMember(dest => dest.OpeningBalanceDate, opt => opt.MapFrom(src => src.OpeningBalanceDate));



        }
    }
}
