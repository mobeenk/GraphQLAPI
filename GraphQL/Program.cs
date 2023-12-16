using GraphQL.Models;
using GraphQL.MutationTypes;
using GraphQL.Queries;
using GraphQL.Repositories;
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
            //builder.Services.AddDbContext<NorthwindContext>(options => 
            //        options.UseSqlServer("Server=localhost;Database=Northwind;Trusted_Connection=True;")
            //);
            //Register Service
            builder.Services.AddScoped<IFacilityRepository, FacilityRepository>();

            builder.Services.AddDbContext<ZyklusCoreContext>(options =>
                  options.UseSqlServer("data source=SWD-SQLUAT-01;initial catalog=ZyklusCore;user id=ZyklusAdmin;password=Rf=z3m@N.nh]/e%M;MultipleActiveResultSets=True;")
          );
            

            builder.Services.AddGraphQLServer()
                            .AddQueryType<FacilityQueryTypes>()
                            .AddMutationType<FacilityMutations>()
                            .AddProjections()
                            .AddFiltering()
                            .AddSorting();

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