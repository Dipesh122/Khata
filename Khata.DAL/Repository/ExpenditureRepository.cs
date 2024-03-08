using Khata.DAL.Models;
using Khata.DAL.Persistance;
using Khata.DAL.Repository.IRepository;

namespace Khata.DAL.Repository
{
    public class ExpenditureRepository : GenericRepository<Expenditure>, IExpenditureRepository
    {
        public ExpenditureRepository(AppDbContext context) : base(context)
        {
        }
    }
}
