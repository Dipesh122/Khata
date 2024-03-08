using Khata.DAL.Models;
using Khata.DAL.Persistance.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Khata.DAL.Persistance
{
    public class AppDbContext : DbContext
    {
        public DbSet<Income> Incomes { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) 
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new IncomeConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenditureConfiguration());
            modelBuilder.ApplyConfiguration(new LoanConfiguration());   
        }
    }
}
