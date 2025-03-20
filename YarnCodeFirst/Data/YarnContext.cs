using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using YarnCodeFirst.Models;

namespace YarnCodeFirst.Data
{
    public class YarnContext : DbContext //db representation
    {
        public DbSet<Yarn> Yarns { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=MATTLAPTOP;initial catalog=Yarn;integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // add dummy records to server
            modelBuilder.Entity<Yarn>().HasData(
                new Yarn
                {
                    YarnId = 1,
                    Color = "magenta",
                    ManufacturerID = 1,
                    weight = Weight.FINGERING,
                    Wholesale = 88.44,
                    Yards = 400
                }
            );

            // add dummy records to server
            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer
                {
                    ManufacturerId = 1,
                    Name = "Malabringo",
                    Address = "here"
                }
            );
        }
    }
}
