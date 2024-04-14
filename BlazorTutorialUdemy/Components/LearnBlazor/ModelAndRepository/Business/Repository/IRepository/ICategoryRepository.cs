using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Models;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository.IRepository
{
    public interface ICategoryRepository
    {
        public CategoryDTO Create(CategoryDTO categoryDTO);
        public CategoryDTO Update(CategoryDTO categoryDTO);
        public int Delete(int id);
        public CategoryDTO GetById(int id);
        public IEnumerable<CategoryDTO> GetAll();


     }
}
