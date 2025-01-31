using Microsoft.EntityFrameworkCore;

namespace PdfGenAPI.Views;

public class TSC_Utilities(DbContextOptions<TSC_Utilities> options) : DbContext(options)
{
    public DbSet<DxCodeTable> DxCodes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
