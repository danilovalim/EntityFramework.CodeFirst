using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF.CodeFirst.Models
{
    public class StoreContext : DbContext
    {
        public DbSet<Product> product { get; set; }
    }
}