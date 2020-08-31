using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
   public interface IBank
    {
        
        Task<Bank> AddBank(Bank Bankaccount, Guid id);
        Bank UpdateBank(Bank Bankaccount);
    }
}
