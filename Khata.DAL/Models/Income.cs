
using Khata.DAL.Models.BaseEntity;

namespace Khata.DAL.Models
{
    public class Income : BaseId
    {
        public DateTime Date { get; set; }
        public string? Detail { get; set; }
        public double Amount { get; set; }
        public string? Category { get; set; }
        public string? GenerateBy { get; set; }
    }
}
