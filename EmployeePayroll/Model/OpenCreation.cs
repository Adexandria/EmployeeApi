using EmployeePayroll.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeePayroll.Model
{
    public class OpenCreation
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "yyyy-mm-dd")]
        public DateTimeOffset OpeningBalanceDate { get; set; }
        public Guid LinesId { get; set; }
        public int Tax { get; set; }

    }
}
