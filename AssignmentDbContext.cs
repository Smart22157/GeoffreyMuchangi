Vusing Microsoft.EntityFrameworkCore;

public class AssignmentDbContext : DbContext
{
    public DbSet<Table1> Table1 { get; set; }
    public DbSet<Table2> Table2 { get; set; }
    public DbSet<Table3> Table3 { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\geoffrey.muchangi\Documents\AssignmentDb.accdb; // Replace with your actual connection string
    }
}

public class Table1
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
