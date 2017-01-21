using GRT.DAL.Configuration.MappingConfiguration.Extensions;
using GRT.DAL.Models.Menus;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Reflection;

namespace CoreEFExp
{
    public class GrtContext : DbContext
    {
        public DbSet<MenuDal> Menus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntityConfigurationsFromAssembly(GetType().GetTypeInfo().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var a = Directory.GetCurrentDirectory();
            // get the configuration from the app settings
            var config = new ConfigurationBuilder()
                  .SetBasePath(Directory.GetCurrentDirectory())
                  .AddJsonFile("appsettings.json")
                  .Build();

            // define the database to use
            String connectionStr = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionStr);
        }
    }
}
