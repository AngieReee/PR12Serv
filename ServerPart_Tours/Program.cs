using ServerPart_Tours.Models;
using ServerPart_Tours.Repositories;
using ServerPart_Tours.Servises;
using ServerPart_Tours.EndPoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PostgresContext>();
builder.Services.AddScoped<ToursRepository>();
builder.Services.AddScoped<ToursService>();
builder.Services.AddScoped<TypesRepository>();
builder.Services.AddScoped<TypesService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapGet("/", () => "Avalonia12");
app.MapToursEndPoints();
app.MapTypesEndPoints();

app.UseSwagger();

if (builder.Environment.IsDevelopment())
{
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.Run();
