using EmployeePayroll.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    public class TemplatesRepository : ITemplates
    {
        private readonly DataDb db;


        public TemplatesRepository(DataDb db)
        {
            this.db = db;

        }
        public  async Task<PayTemplates> AddTemplates(PayTemplates payTemplates, Guid id)
        {
            var query = await GetPay(id);
            if(query== null)
            {
                throw new NullReferenceException(nameof(query));
            }
            query.DeductionId = Guid.NewGuid();
            query.EarningId = Guid.NewGuid();
            query.LinesId = Guid.NewGuid();
            query.ReId = Guid.NewGuid();
            query.SuperId = Guid.NewGuid();
            query.Guid = Guid.NewGuid();
            query.MembershipId = Guid.NewGuid();
            await db.PayTemplates.AddAsync(payTemplates);
            return payTemplates;
        }
        private async Task<PayTemplates> GetPay(Guid Id)
        {
            if(Id== null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.PayTemplates.Where(r => r.PayTemplatesId == Id).FirstOrDefaultAsync();
        }
        public PayTemplates Update(PayTemplates payTemplates)
        {
            var query = db.PayTemplates.Attach(payTemplates);
            query.State = EntityState.Modified;
            return payTemplates;
        }
    }
}
