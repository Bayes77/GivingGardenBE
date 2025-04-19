using GivingGardenBE.Interfaces;
using GivingGardenBE.Models;


namespace GivingGardenBE.Endpoints
{
    public static class PaymentTypesEndpoints
    {
        public static void MapPaymentTypesEndpoints(this WebApplication app)
        {
            // Get all payment types
            app.MapGet("/paymenttypes", async (IPaymentTypeServices paymentType) =>
            {
                var paymentTypes = await paymentType.GetAllPaymentTypes();
                return Results.Ok(paymentTypes);
            })
                .WithName("GetAllPaymentTypes")
                .WithOpenApi()
                .Produces<List<PaymentTypes>>(StatusCodes.Status200OK);

            // Get payment type by ID
            app.MapGet("/paymenttypes/{id}", async (int id, IPaymentTypeServices paymentType) =>
            {
                var paymentTypeById = await paymentType.GetPaymentTypeById(id);
                return Results.Ok(paymentTypeById);
            })
                .WithName("GetPaymentTypeById")
                .WithOpenApi()
                .Produces<PaymentTypes>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound);

            // Create a new payment type
            app.MapPost("/paymenttypes", async (PaymentTypes paymentType, IPaymentTypeServices paymentTypeServices) =>
            {
                var createdPaymentType = await paymentTypeServices.CreatePaymentType(paymentType);
                return Results.Created($"/paymenttypes/{createdPaymentType.Id}", createdPaymentType);
            })
                .WithName("CreatePaymentType")
                .WithOpenApi()
                .Produces<PaymentTypes>(StatusCodes.Status201Created)
                .Produces(StatusCodes.Status400BadRequest);

            // Update an existing payment type
            app.MapPut("/paymenttypes/{id}", async (int id, PaymentTypes paymentType, IPaymentTypeServices paymentTypeServices) =>
            {
                var updatedPaymentType = await paymentTypeServices.UpdatePaymentType(id, paymentType);
                return Results.Ok(updatedPaymentType);
            })
                .WithName("UpdatePaymentType")
                .WithOpenApi()
                .Produces<PaymentTypes>(StatusCodes.Status200OK)
                .Produces(StatusCodes.Status404NotFound);

            // Delete a payment type
            app.MapDelete("/paymenttypes/{id}", async (int id, IPaymentTypeServices paymentTypeServices) =>
            {
                var deletedPaymentType = await paymentTypeServices.DeletePaymentType(id);
                return Results.NoContent();
            })
                .WithName("DeletePaymentType")
                .WithOpenApi()
                .Produces(StatusCodes.Status204NoContent)
                .Produces(StatusCodes.Status404NotFound);
        }
    }
}
