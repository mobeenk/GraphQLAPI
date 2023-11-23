using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddOcelot(builder.Configuration);

// Configure the application
var app = builder.Build();

// Use Ocelot
app.UseOcelot().Wait();

app.Run();
