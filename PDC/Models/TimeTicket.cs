using System;
using System.Collections.Generic;
using System.Text;

namespace PDC.Models
{
   public class TimeTicket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
