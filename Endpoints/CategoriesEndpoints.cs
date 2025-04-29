using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Endpoints
{
    public static class CategoriesEndpoints
    {
        public static void MapCategoriesEndpoints(this WebApplication app)
        {
            app.MapGet("/categories", async (ICategoriesServices categories) =>
            {
                var catagories = await categories.GetAllCategories();
                return Results.Ok(catagories);
            })
            .WithName("GetAllCategories")
            .WithOpenApi()
            .Produces<List<Categories>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status500InternalServerError);
        }
    }
}
