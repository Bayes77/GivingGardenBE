using GivingGardenBE.Models;

namespace GivingGardenBE.Data
{
    public class CategoriesData
    {
        public static List<Categories> Categories = new()
        {
            new() { Id = 1, CategoryName = "Education", },
            new() { Id = 2, CategoryName = "Environment", },
            new() { Id = 3, CategoryName = "Animal Welfare", },
            new() { Id = 4, CategoryName = "Humanitaraian Aid", },
            new() { Id = 5, CategoryName = "Community Development", },
        };
    }
}
