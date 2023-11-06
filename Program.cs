using DevFreela.API.DevFreela.Application.Services.Implementations;
using DevFreela.API.DevFreela.Application.Services.Interfaces;
using DevFreela.API.Models;
using DevFreela.Infrasctructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<DevFreelaDbContext>();
builder.Services.AddScoped<IProjectService, ProjectService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.Configure<OpeningTimeOption>(builder.Configuration.GetSection("OpeningTime"));
builder.Services.AddScoped<ExampleClass>(e => new ExampleClass { Name = "Initial Stage" });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

