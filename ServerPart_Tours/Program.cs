using ServerPart_Tours.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<_43pToursContext>();


var app = builder.Build();


app.Run();
