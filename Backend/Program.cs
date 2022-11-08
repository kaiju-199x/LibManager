using Backend.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<LibDB>(options => options.UseSqlServer
("Server=localhost;DataBase=LibManagerDB;Trusted_Connection=True;Encrypt=False"));

var app = builder.Build();

app.Run();