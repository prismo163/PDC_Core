using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PDC.Models
{
   public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string Role { get; set; }
        
        public Boolean Enabled { get; set; }
        public ICollection<TimeTicket> TimeTickets { get; set; }

        public Employee()
        {
            Enabled = true;
        }
    }
}
