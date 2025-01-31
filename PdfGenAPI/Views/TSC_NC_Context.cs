using Microsoft.EntityFrameworkCore;

namespace PdfGenAPI.Views
{
    public class TSC_NC_Context(DbContextOptions<TSC_NC_Context> options) : DbContext(options)
    {
        public DbSet<EvalTable> EvalViewTable { get; set; }
        public DbSet<PhqTable> PhqTable { get; set; }
        public DbSet<BimsTable> BimsTable { get; set; }
        public DbSet<ClientInfoTable> ClientInfoTable { get; set; }
        public DbSet<AimsTable> AimsTable { get; set; }
        public DbSet<PsychiatryEvalTable> PsychiatryEvalTable { get; set; }
        public DbSet<AppPathTable> AppPathTables { get; set; }
        public DbSet<ProviderTable> ProviderTable { get; set; }
        public DbSet<ProviderTypeTable> ProviderTypeTable { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
