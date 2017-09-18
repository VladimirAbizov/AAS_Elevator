using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAS_Elevator
{
    class ElevatorContext : DbContext
    {
        public ElevatorContext() 
            : base("ElevatorContext") { }

        public DbSet<Account> Accounts { get; set; }
    }
}
