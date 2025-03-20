using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarCodeFirst.Models;

namespace CarCodeFirst.Data
{
    public class CarContext : DbContext // db representation
    {
        // ****************where are we connecting this to the db?
        // whatever DBSet you have will be 'connected' to onmodelcreating
        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseSqlServer("data source=MATTLAPTOP;initial catalog=Car;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData(
                new Car { VIN = 123456, Make = "Toyota", Model = "Prius", Year = 1996, Price = 5500.40 },
                new Car { VIN = 234567, Make = "Toyota", Model = "Highlander", Year = 2004, Price = 9500.40 },
                new Car { VIN = 345678, Make = "Toyota", Model = "Four Runner", Year = 2024, Price = 55000.40 },
                new Car { VIN = 456789, Make = "Toyota", Model = "Prius", Year = 1996, Price = 5500.40 },
                new Car { VIN = 567890, Make = "Toyota", Model = "Highlander", Year = 2025, Price = 25000.00 },
                new Car { VIN = 678901, Make = "Toyota", Model = "Four Runner", Year = 2025, Price = 75000.25 },
                new Car { VIN = 789012, Make = "Toyota", Model = "Prius", Year = 2022, Price = 22000.40 },
                new Car { VIN = 890123, Make = "Toyota", Model = "Highlander", Year = 2020, Price = 32000.25 },
                new Car { VIN = 901234, Make = "Toyota", Model = "Four Runner", Year = 2025, Price = 85000.25 }
            );
        }
    }
}
