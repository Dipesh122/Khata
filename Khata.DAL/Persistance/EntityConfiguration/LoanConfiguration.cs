
using Khata.DAL.Models;
using Khata.DAL.Models.BaseEntity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Khata.DAL.Persistance.EntityConfiguration
{
    public class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.ToTable("Loan", "khata");
        }
    }
}
