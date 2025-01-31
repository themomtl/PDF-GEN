using Microsoft.EntityFrameworkCore;

namespace PdfGenAPI.Views
{
    public class TSC_TX_Context(DbContextOptions<TSC_TX_Context> options) : DbContext(options)
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
            //modelBuilder.Entity<PhqTable>().ToTable(tb => tb.HasTrigger("phq9_provider_app_upd"));
            base.OnModelCreating(modelBuilder);
        }
    }
}
