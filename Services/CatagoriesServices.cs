using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Services
{
    public class CatagoriesServices : ICategoriesServices
    {
        private readonly ICatagoriesRepository _catagoriesRepository;
        public CatagoriesServices(ICatagoriesRepository catagoriesRepository)
        {
            _catagoriesRepository = catagoriesRepository;
        }
        public async Task<List<Categories>> GetAllCategories()
        {
            return await _catagoriesRepository.GetAllCatagories();
        }
    }
    
    
}
