using LibManager.Models;
using Microsoft.EntityFrameworkCore;

namespace LibManager;

public class program
{

    public static void Main(string[] args)
    {
        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();

        string strConn = builder.Configuration.GetConnectionString("LibManagerDB");

        //builder.Services.AddDbContext<LibDB>(option => option.UseInMemoryDatabase("db"));
        builder.Services.AddDbContext<LibDB>(option => option.UseSqlServer(strConn));


        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        WebApplication app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.MapControllers();

        app.Run();
    }
}