using EmployeePayroll.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Services
{
    public class OpenRepository : IOpenBalance
    {
        private readonly DataDb db;


        public OpenRepository(DataDb db)
        {
            this.db = db;

        }
        public async Task<OpenBalances> Add(OpenBalances openBalances, Guid id)
        {
            var query = await GetOpenBalances(id);
            if(query== null)
            {
                throw new NullReferenceException(nameof(query));
            }
            var leaveId = await GetLeaveId(query.LinesId);
         
            await db.OpenBalances.AddAsync(openBalances);
            return openBalances;
        }
        private async Task<PayTemplates> GetLeaveId(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.PayTemplates.Where(r => r.LeaveLines.LeaveLinesId == Id).FirstOrDefaultAsync();
        }
        private async Task<PayTemplates> GetSuperlines(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.PayTemplates.Where(r => r.SuperLines.SuperLinesId == Id).FirstOrDefaultAsync();
        }

        private async Task<PayTemplates> GetReimbursement(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.PayTemplates
                .Where(r => r.ReimbursementLines.ReimbursementLinesId == Id)
                .FirstOrDefaultAsync();
        }
        private async Task<PayTemplates> DeductionId(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.PayTemplates
                .Where(r => r.DeductionLines.DeductionLinesId == Id)
                .FirstOrDefaultAsync();
        }
        private async Task<PayTemplates> EarningsId(Guid Id)
        {
            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.PayTemplates
                .Where(r => r.EarningsLines.EarningsLinesId == Id)
                .FirstOrDefaultAsync();
        }
       
        private async Task<OpenBalances> GetOpenBalances(Guid Id)
        {

            if (Id == null)
            {
                throw new NullReferenceException(nameof(Id));
            }
            return await db.OpenBalances.Where(r => r.OpenBalancesId == Id).FirstOrDefaultAsync();
        }
        public OpenBalances Update(OpenBalances openBalances)
        {
            var query = db.OpenBalances.Attach(openBalances);
            query.State = EntityState.Modified;
            return openBalances;
        }
    }
}
