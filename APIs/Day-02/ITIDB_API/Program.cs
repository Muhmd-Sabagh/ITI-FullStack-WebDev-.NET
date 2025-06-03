
using ITIDB_API.Models;
using ITIDB_API.Repositories;
using ITIDB_API.MapperConfig;
using Microsoft.EntityFrameworkCore;

namespace ITIDB_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string policy = "";
            var builder = WebApplication.CreateBuilder(args);

            //1) Built in services and already register 122
            //2) Built in services Need To Register 313
            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();
            // Database Connection Service
            builder.Services.AddDbContext<ITIContext>(
                options => options.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
                );
            // AutoMapper Service
            builder.Services.AddAutoMapper(typeof(MappingConfigurations));
            // CORS Service
            builder.Services.AddCors(options =>
            {
                options.AddPolicy(
                    policy,
                    builder =>
                    {
                        builder.AllowAnyOrigin();
                        builder.AllowAnyHeader();
                        builder.AllowAnyMethod();
                    }
                );
            });

            //3) Custom Service and Need To Register 315 
            // Register Repositories Services
            builder.Services.AddScoped<IStudentRepository, StudentRepository>();
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwaggerUI(options => options.SwaggerEndpoint("/openapi/v1.json", "v1"));
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(policy);

            app.MapControllers();

            app.Run();
        }
    }
}
