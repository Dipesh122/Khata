
using Khata.DAL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Khata.DAL.Persistance.EntityConfiguration
{
    public class IncomeConfiguration : IEntityTypeConfiguration<Income>
    {
        public void Configure(EntityTypeBuilder<Income> builder)
        {
            builder.ToTable(name:"Income", schema:"khata");
        }
    }
}
        