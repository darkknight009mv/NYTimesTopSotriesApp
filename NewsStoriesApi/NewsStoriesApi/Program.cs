using Microsoft.EntityFrameworkCore;
using NewsStoriesApi.Data;
using NewsStoriesApi.Interfaces;
using NewsStoriesApi.Mappers;
using NewsStoriesApi.Repositories;
using NewsStoriesApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<INYTimesRepository, NYTimesRepository>();
builder.Services.AddScoped<INYTimesMapper, NYTimesMapper>();
builder.Services.AddHttpClient<INYTimesService, NYTimesService>();

builder.Services.AddControllers();

// Swagger
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

app.UseRouting();  // Ensure routing is set up before middleware that depends on it

// Enable CORS (should be before Authorization)
app.UseCors(options =>
    options.WithOrigins("http://localhost:4200")
           .AllowAnyMethod()
           .AllowAnyHeader());

// Swagger UI 
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();  

app.MapControllers();  // Ensure controllers are mapped

app.Run();
