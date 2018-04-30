using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AtosInterveuTask.Models
{
    public class UserOrderContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}