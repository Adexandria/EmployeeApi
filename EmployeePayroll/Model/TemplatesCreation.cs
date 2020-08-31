using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Model
{
    public class TemplatesCreation:PayLinesDto
    {
        public Guid Id { get; set; }
        public Guid SuperId { get; set; }
        public Guid LeaveId { get; set; }
        public Guid LinesId { get; set; }
        public Guid ReId { get; set; }
        public Guid SuperLinesId { get; set; }
        public Guid Guid { get; set; }
        public Guid DeductionLinesId { get; set; }
        public Guid EarningId { get; set; }
        public SuperMemberships SuperMemberships { get; set; }
        public LeaveBalances LeaveBalances { get; set; }
    }
}
