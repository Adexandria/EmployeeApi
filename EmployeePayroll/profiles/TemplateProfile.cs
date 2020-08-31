using AutoMapper;
using EmployeePayroll.Entities;
using EmployeePayroll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.profiles
{
    public class TemplateProfile :Profile
    {
        public TemplateProfile()
        {
            CreateMap<TemplatesCreation, PayTemplates>()
                  .ForMember(dest => dest.PayTemplatesId, opt => opt.MapFrom(src => src.Id))
                .ForPath(dest => dest.SuperMemberships.SuperMembershipsId, opt => opt.MapFrom(src => src.SuperId))
                   .ForPath(dest => dest.SuperMemberships.SuperFundId, opt => opt.MapFrom(src => src.Guid))
                      .ForPath(dest => dest.LeaveLines.LeaveLinesId, opt => opt.MapFrom(src => src.LinesId))
                .ForPath(dest => dest.EarningsLines.EarningsLinesId, opt => opt.MapFrom(src => src.EarningId))
                 .ForPath(dest => dest.DeductionLines.DeductionLinesId, opt => opt.MapFrom(src => src.DeductionLinesId))
                  .ForPath(dest => dest.ReimbursementLines.ReimbursementLinesId, opt => opt.MapFrom(src => src.ReId))
                   .ForPath(dest => dest.SuperLines.SuperLinesId, opt => opt.MapFrom(src => src.SuperLinesId));
            CreateMap<Employee, TemplatesCreation>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.TemplatesId));
            CreateMap<PayTemplates, TemDto>()
                  .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.PayTemplatesId))
                   .ForPath(dest => dest.SuperMemberships.SuperMembershipsId, opt => opt.MapFrom(src => src.SuperMemberships.SuperMembershipsId))
                   .ForPath(dest => dest.SuperMemberships.SuperFundId, opt => opt.MapFrom(src => src.SuperMemberships.SuperFundId))
                      .ForPath(dest => dest.LeaveLines.LeaveLinesId, opt => opt.MapFrom(src => src.LeaveLines.LeaveLinesId))
                .ForPath(dest => dest.EarningsLines.EarningsLinesId, opt => opt.MapFrom(src => src.EarningsLines.EarningsLinesId))
                 .ForPath(dest => dest.DeductionLines.DeductionLinesId, opt => opt.MapFrom(src => src.DeductionLines.DeductionLinesId))
                  .ForPath(dest => dest.ReimbursementLines.ReimbursementLinesId, opt => opt.MapFrom(src => src.ReimbursementLines.ReimbursementLinesId))
                   .ForPath(dest => dest.SuperLines.SuperLinesId, opt => opt.MapFrom(src => src.SuperLines.SuperLinesId)); ;

        }
    }
}
