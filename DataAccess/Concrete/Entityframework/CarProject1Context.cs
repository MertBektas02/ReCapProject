using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.Entityframework
{
    public class CarProject1Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=CarProject1;Trusted_Connection=True");
        }
        public DbSet<CarEntity> CarEntitiesTable { get; set; }
        public DbSet<Color> CarColorTable { get; set; }
        public DbSet<Brand> CarBrandTable { get; set; }
        public DbSet<Customers> CustomersTable { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Rentals> RentalsTable { get; set; }
    }
}
