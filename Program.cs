using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Data;
using GivingGardenBE.Endpoints;
using GivingGardenBE.Interfaces;
using GivingGardenBE.Repositories;
using GivingGardenBE.Services;
using Microsoft.AspNetCore.Http.Json;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// Add configuration to read from user secrets when in development
builder.Services.AddNpgsql<GivingGardenBEDbContext>(builder.Configuration["GivingGardenBEConnectionString"]);

builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});



// Add services to the container.
builder.Services.AddScoped<IOrganizationServices, OrganizationServices>();
builder.Services.AddScoped<IOrganizationRepositroy, OrganizationRepository>();
// builder.Services.AddScoped<ISubscriptionServices, SubscriptionServices>();
// builder.Services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddScoped<IPaymentTypeServices, PaymentTypesRepository>();
builder.Services.AddScoped<PaymentTypesRepository, PaymentTypesRepository>();
builder.Services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
builder.Services.AddScoped<ISubscriptionServices, SubscriptionServices>();
builder.Services.AddScoped<ICategoriesRepository, CategoriesRepository>();
builder.Services.AddScoped<ICategoriesServices, CategoriesServices>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapOrganizationEndpoints();
 app.MapSubscriptionEndpoints();
app.MapUserEndpoints();
app.MapPaymentTypesEndpoints();
app.MapCategoriesEndpoints();

app.Run();
