using DutchTreat.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyProj.Data
{
    public class DutchTreatContext : DbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
    }
}
