using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Endpoints
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/user").WithTags(nameof(User));

            group.MapGet("/", async (IUserServices userService) =>
            {
                return await userService.GetUserAsync();
            })
                .WithName("GetUser")
                .WithOpenApi()
                .Produces<List<User>>(StatusCodes.Status200OK);

            group.MapGet("/{id}", async (IUserServices userService, int id) =>
            {
                var user = await userService.GetUserByIdAsync(id);
                return Results.Ok(user);
            })
                .WithName("GetUserById")
                .WithOpenApi()
                .Produces<User>(StatusCodes.Status200OK);

            group.MapPost("/", async (IUserServices userService, User user) =>
            {
                var userPost = await userService.CreateUserAsync(user);
                return Results.Created($"/api/User/{user.Id}", user);
                })
                .WithName("CreateUser")
                .WithOpenApi()
                .Produces<User>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest);
            
            group.MapPut("/{id}", async (IUserServices userService, int id, User user) =>
            {
                var userUpdate = await userService.UpdateUserAsync(id, user);
                return Results.Ok(user);
            })
                .WithName("UpdateUser")
                .WithOpenApi()
                .Produces<User>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status204NoContent);

            group.MapDelete("/{id}", async (IUserServices userService, int id) =>
            {
                var user = await userService.DeleteUserAsync(id);
                return Results.NoContent();
            })
                .WithName("DeleteUser")
                .WithOpenApi()
                .Produces<User>(StatusCodes.Status204NoContent);
        }
    }
}
