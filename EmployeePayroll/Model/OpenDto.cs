using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Model
{
    public class OpenDto: PayLinesDto
    {
        public Guid Id { get; set; }
      
        public DateTimeOffset OpeningBalanceDate { get; set; }
        public int Tax { get; set; }
    }
}
