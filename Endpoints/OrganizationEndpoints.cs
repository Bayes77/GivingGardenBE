using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;

namespace GivingGardenBE.Endpoints
{
    public static class OrganizationEndpoints
    {
        public static void MapOrganizationEndpoints(this IEndpointRouteBuilder routes)
        {
            var group = routes.MapGroup("/api/organization").WithTags(nameof(Organization));

            // Get all organizations
            routes.MapGet("/", async (IOrganizationServices organizationServices) =>
            {
                return await organizationServices.GetAllOrganizations();
            })
            .WithName("GetAllOrganizations")
            .WithOpenApi()
            .Produces<List<Organization>>(StatusCodes.Status200OK);

            // Get organization by id
            routes.MapGet("/{id}", async (int id, IOrganizationServices organizationServices) =>
            {
                var result = await organizationServices.GetOrganizationById(id);
                return result is not null ? Results.Ok(result) : Results.NotFound();
            })
            .WithName("GetOrganizationById")
            .WithOpenApi()
            .Produces<Organization>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Create organization
            routes.MapPost("/", async (Organization organization, IOrganizationServices organizationServices) =>
            {
                var createdOrg = await organizationServices.CreateOrganization(organization);
                return createdOrg is not null ? Results.Created($"/organizations/{createdOrg.Id}", createdOrg) : Results.BadRequest();
            })
            .WithName("CreateOrganization")
            .WithOpenApi()
            .Produces<Organization>(StatusCodes.Status201Created)
            .Produces(StatusCodes.Status400BadRequest);

            // Update organization
            routes.MapPut("/{id}", async (int id, Organization organization, IOrganizationServices organizationServices) =>
            {
                var updatedOrg = await organizationServices.UpdateOrganization(id, organization);
                return updatedOrg is not null ? Results.Ok(updatedOrg) : Results.NotFound();
            })
            .WithName("UpdateOrganization")
            .WithOpenApi()
            .Produces<Organization>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Delete organization
            routes.MapDelete("/{id}", async (int id, IOrganizationServices organizationServices) =>
            {
                var deletedOrg = await organizationServices.DeleteOrganization(id);
                return deletedOrg is not null ? Results.Ok(deletedOrg) : Results.NotFound();
            })
            .WithName("DeleteOrganization")
             .WithOpenApi()
            .Produces<Organization>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Get subscriptions by organization id
            routes.MapGet("/subscriptions/{orgId}", async (int orgId, IOrganizationServices organizationServices) =>
            {
                var subscriptions = await organizationServices.GetSubscriptionsByOrgId(orgId);
                return subscriptions is not null ? Results.Ok(subscriptions) : Results.NotFound();
            })
            .WithName("GetSubscriptionsByOrgId")
            .WithOpenApi()
            .Produces<List<Subscription>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Get users by organization id
            routes.MapGet("/users/{orgId}", async (int orgId, IOrganizationServices organizationServices) =>
            {
                var users = await organizationServices.GetUsersByOrgId(orgId);
                return users is not null ? Results.Ok(users) : Results.NotFound();
            })
            .WithName("GetUsersByOrgId")
            .WithOpenApi()
            .Produces<List<User>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Get subscriptions by user id
            routes.MapGet("/subscriptions/user/{userId}", async (int userId, IOrganizationServices organizationServices) =>
            {
                var subscriptions = await organizationServices.GetSubscriptionsByUserId(userId);
                return subscriptions is not null ? Results.Ok(subscriptions) : Results.NotFound();
            })
            .WithName("GetSubscriptionsByUserId")
            .WithOpenApi()
            .Produces<List<Subscription>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);

            // Get organizations by user id
            routes.MapGet("/user/{userId}", async (int userId, IOrganizationServices organizationServices) =>
            {
                var organizations = await organizationServices.GetOrganizationsByUserId(userId);
                return organizations is not null ? Results.Ok(organizations) : Results.NotFound();
            })
            .WithName("GetOrganizationsByUserId")
            .WithOpenApi()
            .Produces<List<Organization>>(StatusCodes.Status200OK)
            .Produces(StatusCodes.Status404NotFound);
        }
    }

    }





