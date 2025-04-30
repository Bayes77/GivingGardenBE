using GivingGardenBE.Models;

namespace GivingGardenBE.Interfaces
{
    public interface ICategoriesServices
    {
     
        Task<List<Categories>> GetAllCategories();
    }
}
