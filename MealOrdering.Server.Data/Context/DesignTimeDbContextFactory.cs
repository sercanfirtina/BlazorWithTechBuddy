using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace MealOrdering.Server.Data.Context
{
    public  class DesignTimeDbContextFactory:IDesignTimeDbContextFactory<MealOrderingDbContext>
    {
        public MealOrderingDbContext CreateDbContext(string[] args)
        {
            String connectionString = "Server = DESKTOP-02T3L92; Database = ModelOrderingDb; Trusted_Connection = True;";

            var builder = new DbContextOptionsBuilder<MealOrderingDbContext>();

            builder.UseSqlServer(connectionString);

            return new MealOrderingDbContext(builder.Options);
        }

      
    }
}
