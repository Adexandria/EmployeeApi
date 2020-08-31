using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    public interface IAddress
    {
     Address Update(Address address);
        int Save();
        Task<Address> Add(Address address, Guid id);
    }
}
