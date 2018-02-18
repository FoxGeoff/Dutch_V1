using EmptyProj.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyProj.Data
{
    public class DuchContext : DbContext
    {
        public DuchContext(DbContextOptions options ):base(options)
        {
        }

        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}
