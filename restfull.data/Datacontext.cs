using Microsoft.EntityFrameworkCore;
using restFul.Entities;
using restfull.core.Entities;
using RestFull.Entities;
using System.Collections.Generic;

namespace CreateApi
{
    public class DataContext:DbContext
    {
        //Nuget Packages

/* Install in Data Project 
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools*/

/* Install in API Project 
Microsoft.EntityFrameworkCore.Design*/

        public DbSet<Guest> guests { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<Invetation> Invetations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SariRestfull_db");
        }

       





    }
}