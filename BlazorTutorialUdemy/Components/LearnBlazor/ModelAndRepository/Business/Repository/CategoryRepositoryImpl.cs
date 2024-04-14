using AutoMapper;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository.IRepository;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data;
using BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Models;

namespace BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.Business.Repository
{
    public class CategoryRepositoryImpl : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;

        private readonly IMapper _mapper;


        public CategoryRepositoryImpl(ApplicationDbContext db,IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public CategoryDTO Create(CategoryDTO categoryDTO)
        {
            var category = _mapper.Map<CategoryDTO, BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.Category>(categoryDTO);

            category.CreatedDate = DateTime.Now;

            var addedCategory = _db.Categories.Add(category);

            _db.SaveChanges();
            /*Default Creation
            Category category = new Category()
            {
                Name = categoryDTO.Name,
                Id = categoryDTO.Id,
                CreatedDate = DateTime.Now
            };

           _db.Categories.Add(category);
           _db.SaveChanges();
            */

            return _mapper.Map<BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.Category, CategoryDTO>(addedCategory.Entity);
        }

        public int Delete(int id)
        {
            var category = _db.Categories.FirstOrDefault(u=> u.Id == id);

            if (category != null)
            {
                _db.Categories.Remove(category);
                return _db.SaveChanges();
            }
            return 0;

            
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
           return _mapper.Map<IEnumerable<BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.Category>,IEnumerable<CategoryDTO>>(_db.Categories);
        }

        public CategoryDTO GetById(int id)
        {
            var category = _db.Categories.FirstOrDefault(u => u.Id == id);

            if (category != null)
            {
               _mapper.Map<BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.Category, CategoryDTO>(category);
            }
            return new CategoryDTO();
        }

        public CategoryDTO Update(CategoryDTO categoryDTO)
        {
            var categoryFromDb = _db.Categories.FirstOrDefault(u => u.Id == categoryDTO.Id);
            if(categoryFromDb != null)
            {
                categoryFromDb.Name = categoryDTO.Name;
                _db.Categories.Update(categoryFromDb);
                _db.SaveChanges();
                return _mapper.Map<BlazorTutorialUdemy.Components.LearnBlazor.ModelAndRepository.DataAccess.Data.Category, CategoryDTO>(categoryFromDb);
            }

            return categoryDTO;



        }
    }
}
