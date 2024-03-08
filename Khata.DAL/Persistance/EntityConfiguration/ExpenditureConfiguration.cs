
using Khata.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Khata.DAL.Persistance.EntityConfiguration
{
    public class ExpenditureConfiguration : IEntityTypeConfiguration<Expenditure>
    {
        public void Configure(EntityTypeBuilder<Expenditure> builder)
        {
            builder.ToTable(name:"Expenditure", schema:"khata");
            builder.Property(e => e.Date)
                .HasConversion 
                (
                    src => src.Kind == DateTimeKind.Utc ? src : DateTime.SpecifyKind(src, DateTimeKind.Utc),
                    dst => dst.Kind == DateTimeKind.Utc ? dst : DateTime.SpecifyKind(dst, DateTimeKind.Utc)
                );
        }
    }
}
