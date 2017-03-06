﻿using Microsoft.EntityFrameworkCore;

namespace Angular2Demo.Data
{
    public class ApplicationDbContext : DbContext
    {
       /* public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }*/
        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            optionbuilder.UseSqlServer(@"Server = (LocalDb)\MSSQLLocalDB; Database = product_manage1.dbo");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employee { get; set; }
    }
}
