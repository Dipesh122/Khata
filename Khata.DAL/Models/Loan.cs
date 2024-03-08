
using Khata.DAL.Models.BaseEntity;

namespace Khata.DAL.Models
{
    public class Loan : BaseId
    {
        public DateTime Date { get; set; }
        public string? Name { get; set; }
        public double Amount { get; set; }
        public string? Method { get; set; }
    }
}
