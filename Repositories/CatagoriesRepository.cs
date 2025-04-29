using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;
using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Data;


namespace GivingGardenBE.Repositories
{
    public class CatagoriesRepository : ICatagoriesRepository
    {
        private readonly GivingGardenBEDbContext _context;
        public CatagoriesRepository(GivingGardenBEDbContext context)
        {
            _context = context;
        }
        public async Task<List<Categories>> GetAllCatagories()
        {
            return await _context.Categories.ToListAsync();
        }
    }
    
    
}
