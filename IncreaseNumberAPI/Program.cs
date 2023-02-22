using IncreaseNumberAPI.AutoMapers;
using IncreaseNumberAPI.DAL;
using IncreaseNumberAPI.DAL.Entities;
using IncreaseNumberAPI.DAL.Intefaces;
using IncreaseNumberAPI.Services;
using IncreaseNumberAPI.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

string? connection = builder.Configuration
    .GetConnectionString("DefaultConnection");

builder.Services
    .AddDbContext<NumberIncreaseContext>(option => option.UseSqlServer(connection))
    .AddScoped<INumberRepository, NumberRepository>()
    .AddSingleton<NumberMapper>()
    .AddScoped<IBootstrap, BootstrapService>()
    .AddScoped<IIncrement, IncrementService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod());

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
