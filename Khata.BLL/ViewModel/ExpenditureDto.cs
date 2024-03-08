
namespace Khata.BLL.ViewModel
{
    public record ExpenditureDto
    {
        public Guid Id { get; init; }
        public DateTime Date { get; init; }
        public string? Detail { get; init; }
        public double Cost { get; init; }
        public string? Category { get; init; }
        public string? SpendBy { get; init; }
    }
}
