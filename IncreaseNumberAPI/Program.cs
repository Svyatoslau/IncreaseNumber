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

var config = builder.Configuration;

string? connection = config.GetConnectionString("DefaultConnection");
string[] origins = config.GetSection("AllowedOrigins").Value.Split(";");

builder.Services
    .AddDbContext<TestDbContext>(option => option.UseSqlServer(connection))
    .AddScoped<ICounterRepository, CounterRepository>()
    .AddSingleton<CounterMapper>()
    .AddScoped<IBootstrap, BootstrapService>()
    .AddScoped<IIncrement, IncrementService>();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder.WithOrigins(origins)
                            .AllowAnyHeader()
                            .AllowAnyMethod());

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
