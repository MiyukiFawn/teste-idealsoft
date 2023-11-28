using Microsoft.EntityFrameworkCore;

namespace API;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<ApiDbContext>();

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        var app = builder.Build();

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();
        app.MapGet("/", () => "Hello world!");

        app.Run();
    }
}