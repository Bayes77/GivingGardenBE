using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Endpoints
{
    public static class SubscriptionEndpoints
    {
        public static void MapSubscriptionEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/subscription").WithTags(nameof(Subscription));

            // Get subscription by ID
            group.MapGet("/{id}", async (int id, ISubscriptionServices service) =>
            {
                var sub = await service.GetSubscriptionById(id);
                return sub is not null ? Results.Ok(sub) : Results.NotFound();
            })
            .WithName("GetSubscriptionById")
            .Produces<Subscription>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Get subscriptions by User ID
            group.MapGet("/user/{userId}", async (int userId, ISubscriptionServices service) =>
            {
                var subs = await service.GetSubscriptionsByUserId(userId);
                return Results.Ok(subs);
            })
            .WithName("GetSubscriptionsByUserId")
            .Produces<List<Subscription>>(StatusCodes.Status200OK);

            // Create subscription
            group.MapPost("/", async (Subscription sub, ISubscriptionServices service) =>
            {
                var created = await service.CreateSubscription(sub);
                return created is not null ? Results.Created($"/api/subscription/{created.Id}", created) : Results.BadRequest();
            })
            .WithName("CreateSubscription")
            .Produces<Subscription>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            // Delete subscription
            group.MapDelete("/{id}", async (int id, ISubscriptionServices service) =>
            {
                var deleted = await service.DeleteSubscription(id);
                return deleted is not null ? Results.Ok(deleted) : Results.NotFound();
            })
            .WithName("DeleteSubscription")
            .Produces<Subscription>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
        }
    }
}

