using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;
using System.Text.RegularExpressions;

namespace GivingGardenBE.Endpoints
{
    public static class SubscriptionEndpoints
    {
        public static void MapSubscriptionEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/subscription").WithTags(nameof(Subscription));

            // Create subscription
            group.MapPost("/", async (Subscription sub, ISubscriptionServices service) =>
            {
                var created = await service.CreateSubscription(sub);
                return created is not null ? Results.Created($"/api/subscription/{created.Id}", created) : Results.BadRequest();
            })
            .WithName("CreateSubscription")
            .WithOpenApi()
            .Produces<Subscription>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            // Delete subscription
            group.MapDelete("/{id}", async (int id, ISubscriptionServices service) =>
            {
                var deleted = await service.DeleteSubscription(id);
                return deleted is not null ? Results.Ok(deleted) : Results.NotFound();
            })
            .WithName("DeleteSubscription")
            .WithOpenApi()
            .Produces<Subscription>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Update subscription
            group.MapPut("/{id}", async (int id, Subscription subscription, ISubscriptionServices subscriptionservice) =>
            {
                var existingSub = await subscriptionservice.UpdateSubscription(id,subscription);
                return Results.Ok(existingSub);
               
            })
            .WithName("UpdateSubscription")
            .WithOpenApi()
            .Produces<Subscription>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status400BadRequest)
            .Produces(StatusCodes.Status404NotFound);

            // Get subscriptions by organization id
            group.MapGet("/{orgId}", async (int orgId, IOrganizationServices organizationServices) =>
            {
                var subscriptions = await organizationServices.GetSubscriptionsByOrgId(orgId);
                return subscriptions is not null ? Results.Ok(subscriptions) : Results.NotFound();
            })
            .WithName("GetSubscriptionsByOrgId")
            .WithOpenApi()
            .Produces<List<Subscription>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Get subscriptions by subscription id
            group.MapGet("/{id}", async (int id, ISubscriptionServices subscriptionServices) =>
            {
                var subscriptions = await subscriptionServices.GetSubscriptionById(id);
                return subscriptions is not null ? Results.Ok(subscriptions) : Results.NotFound();
            })
            .WithName("GetSubscriptionById")
            .WithOpenApi()
            .Produces<Subscription>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
        }
    }
   
    
}

