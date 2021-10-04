using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(
                new Country { Id = 1, Name = "Jamaica", ShortName = "JM" },
                new Country { Id = 2, Name = "Bahamas", ShortName = "Bs" },
                new Country { Id = 3, Name = "Cayman Islands", ShortName = "CI" }
                );
            modelBuilder.Entity<Hotel>().HasData(
                new Hotel { Id = 1, Name = "Super", Address = "Negrili", CountryId = 2 },
                new Hotel { Id = 2, Name = "Spa", Address = "Negrili", CountryId = 3 },
                new Hotel { Id = 3, Name = "Grand", Address = "Negrili", CountryId = 1 }
                );
        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Country> Countries { get; set; }
    }
}
