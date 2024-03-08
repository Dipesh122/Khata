
using AutoMapper;
using Khata.BLL.ViewModel;
using Khata.DAL.Models;

namespace Khata.BLL
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Expenditure, ExpenditureDto>().ReverseMap();
        }
    }
}
