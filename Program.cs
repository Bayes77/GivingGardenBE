using Microsoft.EntityFrameworkCore;
using GivingGardenBE.Data;
using GivingGardenBE.Endpoints;
using GivingGardenBE.Interfaces;
using GivingGardenBE.Repositories;
using GivingGardenBE.Services;

var builder = WebApplication.CreateBuilder(args);

// Add configuration to read from user secrets when in development
if (builder.Environment.IsDevelopment())
{
    builder.Configuration.AddUserSecrets<Program>();
}

var connectionString = builder.Configuration.GetConnectionString("GivingGardenBEDbConnection");
builder.Services.AddDbContext<GivingGardenBEDbContext>(options => options.UseNpgsql(connectionString));

builder.Services.AddScoped<IOrganizationServices, OrganizationServices>();
builder.Services.AddScoped<IOrganizationRepositroy, OrganizationRepository>();
// builder.Services.AddScoped<ISubscriptionServices, SubscriptionServices>();
// builder.Services.AddScoped<ISubscriptionRepository, SubscriptionRepository>();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapOrganizationEndpoints();
// app.MapSubscriptionEndpoints();
app.MapUserEndpoints();

app.Run();
