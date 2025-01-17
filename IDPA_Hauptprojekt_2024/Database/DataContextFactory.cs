﻿using IDPA_Hauptprojekt_2024.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace IDPA_Hauptprojekt_2024_Migration.Database
{
    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        private static DataContext _context;

        public DataContext CreateDbContext(string[] args)
        {
            if (_context == null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
                optionsBuilder.UseSqlite("Data Source=IDPA_Hauptprojekt_2024.db");

                optionsBuilder.EnableSensitiveDataLogging();


                return new DataContext(optionsBuilder.Options);
            }
            return _context;
        }

        public DataContext GetContext()
        {
            return _context;
        }
    }
}