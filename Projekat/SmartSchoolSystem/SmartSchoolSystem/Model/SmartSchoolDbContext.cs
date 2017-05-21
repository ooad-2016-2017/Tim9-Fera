using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace SmartSchoolSystem.Model
{
    class SmartSchoolDbContext:DbContext
    {
        public DbSet<SmartSchoolSystem> sistem { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            String databaseFilePath = "SmartSchoolSistemBaza.db";
            try
            {
                databaseFilePath = Path.Combine(ApplicationData.Current.LocalFolder.Path, databaseFilePath);
            }
            catch (InvalidOperationException) { }
            optionsBuilder.UseSqlite($"Data source={databaseFilePath}");
        }

        
    }
}
