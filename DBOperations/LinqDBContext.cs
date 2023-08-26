using LinqPractices.Entities;
using Microsoft.EntityFrameworkCore;

namespace LinqPractices.DBOperations;

public class LinqDBContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase(databaseName: "LinqDatabase");
    }
}