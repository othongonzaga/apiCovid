using apiCOVID.Data;
using Microsoft.EntityFrameworkCore;

namespace apiCOVID
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<apiCovidDBContext>(options => options.UseNpgsql("Server=babar.db.elephantsql.com;Database=sqkttydt;User Id=sqkttydt;Password=V6cFtlsEPArPiMVtET65EGTfQWlBqpgw;"));

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
        }
    }
}