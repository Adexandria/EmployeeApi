using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    public interface IOpenBalance
    {
        OpenBalances Update(OpenBalances openBalances);
        Task<OpenBalances> Add(OpenBalances openBalances, Guid id);
    }
}
