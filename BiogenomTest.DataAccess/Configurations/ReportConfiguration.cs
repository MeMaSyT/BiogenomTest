using BiogenomTest.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BiogenomTest.DataAccess.Configurations
{
    public class ReportConfiguration : IEntityTypeConfiguration<ReportEntity>
    {
        public void Configure(EntityTypeBuilder<ReportEntity> builder)
        {
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Current_VitaminC)
                .IsRequired();

            builder.Property(r => r.Current_VitaminD)
               .IsRequired();

            builder.Property(r => r.Current_Water)
               .IsRequired();

            builder.Property(r => r.Current_Cink)
               .IsRequired();

            builder.Property(r => r.Current_Energy)
               .IsRequired();

            builder.Property(r => r.New_VitaminD)
               .IsRequired();

            builder.Property(r => r.New_Cink)
               .IsRequired();

            builder.Property(r => r.New_Iodine)
               .IsRequired();

            builder.Property(r => r.New_VitaminB6)
               .IsRequired();

            builder.Property(r => r.New_VitaminС)
               .IsRequired();
        }
    }
}
