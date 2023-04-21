using System.Collections.Generic;
using IO.Swagger.Models;
using Microsoft.EntityFrameworkCore;


namespace IO.Swagger
{
    public class AppDbContext : DbContext
    {
        public DbSet<Type0x0A> Type0x0AEntities { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "MyDatabase");
        }
    }
}
