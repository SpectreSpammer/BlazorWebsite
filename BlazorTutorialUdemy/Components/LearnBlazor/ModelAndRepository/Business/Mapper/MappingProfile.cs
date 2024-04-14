using AutoMapper;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Models;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.Category, CategoryDTO>().ReverseMap();
            //CreateMap<CategoryDTO, Category>();
        }
    }
}
