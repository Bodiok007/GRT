using GRT.DAL.Configuration.MappingConfiguration.Extensions;
using GRT.DAL.Models.Languages;
using GRT.DAL.Models.Levels;
using GRT.DAL.Models.Levels.Dialogs;
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
        #region Menus

        public DbSet<MenuDal> Menus { get; set; }
        public DbSet<MenuTranslateDal> MenuTranslates { get; set; }
        public DbSet<MenuAttributeDal> MenuAttributes { get; set; }
        public DbSet<MenuAttributeValueDal> MenuAttributeValues { get; set; }
        public DbSet<MenuAttributeTranslateDal> MenuAttributeTranslates { get; set; }
        public DbSet<MenuAttributeValueTranslateDal> MenuAttributeValueTranslates { get; set; }

        #endregion

        #region Levels

        public DbSet<LevelDal> Levels { get; set; }
        public DbSet<LevelDialogDal> LevelDialogs { get; set; }
        public DbSet<LevelTranslateDal> LevelTranslates { get; set; }

        #endregion

        #region LevelDialogs

        public DbSet<DialogDal> Dialogs { get; set; }
        public DbSet<DialogTextDal> DialogTexts { get; set; }
        public DbSet<DialogRecordDal> DialogRecords { get; set; }
        public DbSet<DialogTextTranslateDal> DialogTextTranslates { get; set; }
        public DbSet<DialogRecordTranslateDal> DialogRecordTranslates { get; set; }

        #endregion

        public DbSet<LanguageDal> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddEntityConfigurationsFromAssembly(GetType().GetTypeInfo().Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
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
