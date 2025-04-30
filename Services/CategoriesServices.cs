using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Services
{
    public class CategoriesServices : ICategoriesServices
    {
        private readonly ICategoriesRepository _categoriesRepository;
        public CategoriesServices(ICategoriesRepository categoriesRepository)
        {
            _categoriesRepository = categoriesRepository;
        }

        public async Task<List<Categories>> GetAllCategories()
        {
            return await _categoriesRepository.GetAllCategories();
        }
    }
    
    
}
