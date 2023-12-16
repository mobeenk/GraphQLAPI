using GraphQL.Models;
using GraphQL.Queries;
using Microsoft.EntityFrameworkCore;

namespace GraphQL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(builder =>
                {
                    builder.WithOrigins("http://localhost:4200")
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                    
                });
            });

            builder.Services.AddControllers();
            builder.Services.AddDbContext<NorthwindContext>(options => 
                    options.UseSqlServer("Server=localhost;Database=Northwind;Trusted_Connection=True;")
            );
            builder.Services.AddGraphQLServer().AddQueryType<Query>().AddProjections().AddFiltering().AddSorting();
            //builder.Services.AddGraphQL().AddQueryType();
            var app = builder.Build();
      
            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            app.MapGraphQL();
            app.UseCors();
            app.Run();
        }
    }
}