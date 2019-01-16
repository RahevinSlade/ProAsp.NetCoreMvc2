using System;
using Microsoft.EntityFrameworkCore;

namespace WebApplicationDemo
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }

    }
}