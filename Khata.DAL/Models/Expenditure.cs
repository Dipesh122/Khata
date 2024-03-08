
using Khata.DAL.Models.BaseEntity;

namespace Khata.DAL.Models
{
    public class Expenditure : BaseId
    {
        public DateTime Date { get; set; }
        public string? Detail { get; set; }
        public double Cost { get; set; }
        public string? Category { get; set; }
        public string? SpendBy { get; set; }
    }
}
