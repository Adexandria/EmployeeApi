using EmployeePayroll.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    public class AddressRepository : IAddress
    {
        private readonly DataDb db;


        public AddressRepository(DataDb db)
        {
            this.db = db;

        }
        public  async Task<Address> Add(Address address, Guid id)
        {
            var query = await GetAddress(id);
            if (query == null)
            {
                throw new NullReferenceException(nameof(query));
            }
            await db.Address.AddAsync(address);
            await db.SaveChangesAsync();
            return address;
        }
        private async Task<Address> GetAddress(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.Address.Where(r => r.HomeAddressId == Id).AsNoTracking().FirstOrDefaultAsync();
        }

        public Address Update(Address address)
        {
            if (GetAddress(address.HomeAddressId) == null)
            {
                throw new NullReferenceException(nameof(address.HomeAddressId));
            }

            var query = db.Address.Attach(address);
            query.State = EntityState.Modified;
            return address;
        }

        public int Save()
        {
           return  db.SaveChanges();
        }
    }
}
