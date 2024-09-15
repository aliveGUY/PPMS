using DotNetEnv;
using back.Data;
using Microsoft.EntityFrameworkCore;
using back.Interfaces;
using back.Repository;

var builder = WebApplication.CreateBuilder(args);

Env.Load();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});

builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(Env.GetString("CONNECTION_STRING"));
});

builder.Services.AddScoped<IPlaygroundRepository, PlaygroundRepository>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("AllowSpecificOrigins");
app.MapControllers();
app.Run();
