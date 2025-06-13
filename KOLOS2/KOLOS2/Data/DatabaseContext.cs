using Microsoft.EntityFrameworkCore;

namespace KOLOS2.Data;

public class DatabaseContext : DbContext
{
    
    // public Dbsets
    protected DatabaseContext(){}
    public DatabaseContext(DbContextOptions options) : base(options){}
}