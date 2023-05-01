using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieSystem_MVC_API.Data.EFCore;
namespace MovieSystem_MVC_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddDbContext<MovieSystem_MVC_APIContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("MovieSystem_MVC_APIContext") ?? throw new InvalidOperationException("Connection string 'MovieSystem_MVC_APIContext' not found.")));

            // Add services to the container.
            builder.Services.AddScoped<EfCorePersonRepository>();
            builder.Services.AddScoped<EfCoreGenreRepository>();
            builder.Services.AddScoped<EfCoreMovieRepository>();
            builder.Services.AddScoped<EfCoreLikedGenreRepository>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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