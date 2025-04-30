using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;
using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Data;


namespace GivingGardenBE.Repositories
{
    public class CategoriesRepository : ICategoriesRepository
    {
        private readonly GivingGardenBEDbContext _context;
        public CategoriesRepository(GivingGardenBEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Categories>> GetAllCategories()
        {
            return await _context.Categories.ToListAsync();
        }
    }


}
