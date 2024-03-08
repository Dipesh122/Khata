
using Khata.BLL.ViewModel;

namespace Khata.BLL.Services.IServices
{
    public interface IExpenditureServices
    {
        Task<ExpenditureDto> AddAsync(ExpenditureDto entity);
        Task<ExpenditureDto> UpdateAsync(ExpenditureDto dto);
        Task<ExpenditureDto> DeleteAsync(Guid id);
        Task<ExpenditureDto> GetByIdAsync(Guid id);
        Task<List<ExpenditureDto>> GetAllAsync();
    }
}
