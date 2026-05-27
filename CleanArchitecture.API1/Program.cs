using CleanApi.Application.Interfaces;
using CleanApi.Application.Products.Queries;
using CleanApi.Infrastructure.Data;
using CleanApi.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Lägger till controllers
builder.Services.AddControllers();

// Lägger till Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Lägger till MediatR
builder.Services.AddMediatR(cfg =>
{
    cfg.RegisterServicesFromAssembly(typeof(GetAllProductsQuery).Assembly);
});

// Kopplar interface till repository
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Kopplar projektet till SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

// Startar Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();