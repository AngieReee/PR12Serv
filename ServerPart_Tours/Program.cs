using ServerPart_Tours.Models;
using ServerPart_Tours.Repositories;
using ServerPart_Tours.Servises;
using ServerPart_Tours.EndPoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<_43pToursContext>();
builder.Services.AddScoped<ToursRepository>();
builder.Services.AddScoped<ToursService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Avalonia12");
app.MapToursEndPoints();

app.UseSwagger();
app.UseSwaggerUI();

app.Run();
