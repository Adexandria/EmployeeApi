using EmployeePayroll.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    public class Bankrepository : IBank
    {
        private readonly DataDb db;
        

        public Bankrepository(DataDb db)
        {
            this.db = db;
         
        }
        public async Task<Bank> AddBank(Bank Bankaccount, Guid id)
        {
            var query = await GetBank(id);
            if(query == null)
            {
                throw new NullReferenceException(nameof(query));
            }
            await db.Bank.AddAsync(Bankaccount);
            return Bankaccount;
        }
        private async Task<Bank> GetBank(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.Bank.Where(r => r.BankAccountId == Id).FirstOrDefaultAsync();
        }
        public Bank UpdateBank(Bank Bankaccount)
        {
            var query = db.Bank.Attach(Bankaccount);
            query.State = EntityState.Modified;
            return Bankaccount;
        }
    }
}
