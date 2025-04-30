using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface ICategoriesRepository
    {
        Task<List<Categories>> GetAllCategories();
       
    }
}
