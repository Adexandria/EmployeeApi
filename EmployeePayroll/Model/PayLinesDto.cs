using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Model
{
    public abstract class PayLinesDto
    {
        public EarningsLines EarningsLines { get; set; }
        public DeductionLines DeductionLines { get; set; }
        public SuperLines SuperLines { get; set; }
        public ReimbursementLines ReimbursementLines { get; set; }
        public LeaveLines LeaveLines { get; set; }
       
        
    }
}
