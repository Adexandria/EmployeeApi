using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    interface ITemplates
    {
        PayTemplates Update(PayTemplates payTemplates);
        Task<PayTemplates> AddTemplates(PayTemplates payTemplates, Guid id);
    }
}
