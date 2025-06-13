using KOLOS2.Models;
using Microsoft.EntityFrameworkCore;

namespace KOLOS2.Data;

public class DatabaseContext : DbContext
{
    
    public DbSet<Nursery> Nursery { get; set; }
    public DbSet<SeedlingBatch> SeedlingBatch { get; set; }
    public DbSet<TreeSpecies> TreeSpecies { get; set; }
    public DbSet<Responsible> Responsible { get; set; }
    public DbSet<Employee> Employee { get; set; }
    
    protected DatabaseContext(){}
    public DatabaseContext(DbContextOptions options) : base(options){}
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nursery>().HasData(new List<Nursery>()
        {
            new Nursery() { NurseryId = 1, Name = "nur1", EstablishsedDate = DateTime.Parse("2025-05-01") },
            new Nursery() { NurseryId = 2, Name = "nur2", EstablishsedDate = DateTime.Parse("2025-05-01") },
        });
        modelBuilder.Entity<TreeSpecies>().HasData(new List<TreeSpecies>()
        {
            new TreeSpecies() { SpaciesId = 1, LatinName = "dab", GrowthTimeInYears = 12 },
            new TreeSpecies() { SpaciesId = 2, LatinName = "wierzba", GrowthTimeInYears = 12 },
            new TreeSpecies() { SpaciesId = 3, LatinName = "jesion", GrowthTimeInYears = 12 }
        });
        modelBuilder.Entity<Employee>().HasData(new List<Employee>()
        {
            new Employee()
                { EmployeeId = 1, FirstName = "adam", LastName = "jesion", HireDate = DateTime.Parse("2005-05-01") },
            new Employee()
                { EmployeeId = 2, FirstName = "adam", LastName = "jesion", HireDate = DateTime.Parse("2005-05-01") },
        });
        modelBuilder.Entity<SeedlingBatch>().HasData(new List<SeedlingBatch>()
        {
            new SeedlingBatch()
                { BatchId = 1, NurseryId = 1, SpeciesId = 1, Quantity = 20, SownDate = DateTime.Parse("2025-05-01") },
            new SeedlingBatch()
                { BatchId = 2, NurseryId = 2, SpeciesId = 2, Quantity = 20, SownDate = DateTime.Parse("2025-05-01") },
            new SeedlingBatch()
                { BatchId = 3, NurseryId = 1, SpeciesId = 3, Quantity = 20, SownDate = DateTime.Parse("2025-05-01") },
            new SeedlingBatch()
                { BatchId = 4, NurseryId = 1, SpeciesId = 2, Quantity = 20, SownDate = DateTime.Parse("2025-05-01") },
        });
        modelBuilder.Entity<Responsible>().HasData(new List<Responsible>()
        {
            new Responsible() { BatchId = 1, EmployeeId = 1, Role = "role1" },
            new Responsible() { BatchId = 2, EmployeeId = 1, Role = "role1" },
            new Responsible() { BatchId = 3, EmployeeId = 2, Role = "role2" },
            new Responsible() { BatchId = 4, EmployeeId = 1, Role = "role1" },
            new Responsible() { BatchId = 3, EmployeeId = 1, Role = "role2" },
        });


    }
    
}