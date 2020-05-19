using Microsoft.EntityFrameworkCore;
using PDC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace PDC.Data
{
   public class AppDbContext : DbContext
    {
        public DbSet<Employee>  Employees { get; set; }
        public DbSet<TimeTicket> TimeTickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           //  optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["PDC"].ConnectionString);
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=PDC;Integrated Security=True");
        }
    }
}
