using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace dockertraining_compose_salvador_jimenez.Models
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<FoodContext>
    {
        public FoodContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<FoodContext>();
            var connectionString = configuration.GetSection("ConnectionStrings").GetSection("FoodDB").Value;
            builder.UseSqlServer(connectionString);
            return new FoodContext(builder.Options);
        }
    }
}
