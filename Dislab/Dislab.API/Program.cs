
using Dislab.API.Base;
using Dislab.API.DbContexts;
using Dislab.API.Services;

namespace Dislab.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddTransient<IDapperContext, DapperContext>();
            builder.Services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
            builder.Services.AddTransient<IEmployeeServices, EmployeeServices>();
            builder.Services.AddHttpContextAccessor();

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