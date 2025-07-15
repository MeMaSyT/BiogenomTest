using BiogenomTest.DataAccess.Configurations;
using BiogenomTest.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BiogenomTest.DataAccess
{
    public class ProgramDbContext(DbContextOptions<ProgramDbContext> options) 
        : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReportConfiguration());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ReportEntity> Reports { get; set; }
    }
}
