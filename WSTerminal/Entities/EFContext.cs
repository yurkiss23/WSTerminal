using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WSTerminal.Entities
{
    public class EFContext : DbContext
    {
        public EFContext() : base("DefConnection")
        {

        }
        public DbSet<User> Users { get; set; }
    }
}