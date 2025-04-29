using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Endpoints
{
    public static class CategoriesEndpoints
    {
        public static void MapCategoriesEndpoints(this IEndpointRouteBuilder routes)
        {
            routes.MapGet("/categories", async (ICategoriesServices categoriesServices) =>
            {
                var categories = await categoriesServices.GetAllCategories();
                return Results.Ok(categories);
            })
            .WithName("GetAllCategories")
            .Produces<List<Categories>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status500InternalServerError);
        }
    }
}
