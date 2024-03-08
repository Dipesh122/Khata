
using AutoMapper;
using Khata.BLL.Services.IServices;
using Khata.BLL.ViewModel;
using Khata.DAL.Models;
using Khata.DAL.Repository.IRepository;

namespace Khata.BLL.Services
{
    public class ExpenditureServices : IExpenditureServices
    {
        private readonly IExpenditureRepository _repository;
        private readonly IMapper _mapper;
        public ExpenditureServices(IExpenditureRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;   
        }
        public async Task<ExpenditureDto> AddAsync(ExpenditureDto dto)
        {
            var entity = _mapper.Map<Expenditure>(dto);
            entity.Date = DateTime.SpecifyKind(dto.Date, DateTimeKind.Utc);
            var result = await _repository.AddAsync(entity);
            await _repository.SaveChangeAsync();
            return _mapper.Map<ExpenditureDto>(result);
        }

        public async Task<ExpenditureDto> DeleteAsync(Guid id)
        {
            var result = await _repository.DeleteAsync(id);
            await _repository.SaveChangeAsync();
            return _mapper.Map<ExpenditureDto>(result);
        }

        public async Task<List<ExpenditureDto>> GetAllAsync()
        {
            var result = await _repository.GetAllAsync();
            return _mapper.Map<List<ExpenditureDto>>(result);
        }

        public async Task<ExpenditureDto> GetByIdAsync(Guid id)
        {
            var result = await _repository.GetByIdAsync(id);
            return _mapper.Map<ExpenditureDto>(result);
        }

        public async Task<ExpenditureDto> UpdateAsync(ExpenditureDto dto)
        {
            var entity = _mapper.Map<Expenditure>(dto);
            var result = _repository.UpdateAsync(entity);
            await _repository.SaveChangeAsync();
            return _mapper.Map<ExpenditureDto>(result);
        }
    }
}
