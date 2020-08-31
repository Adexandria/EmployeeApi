using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeePayroll.Entities
{
    public class PayTemplates:PayLines
    {
        [Key]
        public Guid PayTemplatesId { get; set; }
        public Guid LinesId { get; set; }
        public Guid ReId { get; set; }
        public Guid SuperId { get; set; }
        public Guid MembershipId { get; set; }
        public Guid Guid { get; set; }
        public Guid DeductionId { get; set; }
        public Guid EarningId { get; set; }
        public SuperMemberships SuperMemberships { get; set; }
        public LeaveBalances LeaveBalances { get; set; }
    }
}