#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using wenesday.Models;

namespace wenesday.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<wenesday.Models.Product> Product { get; set; }
        public DbSet<wenesday.Models.Customer> Customer { get; set; }
    }
}
