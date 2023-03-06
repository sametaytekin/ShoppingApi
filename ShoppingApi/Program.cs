using Autofac;
using Autofac.Extensions.DependencyInjection;
using ShoppingApi.AutoFac;
using ShoppingApi.Base.Token;
using ShoppingApi.Data.Context;
using ShoppingApi.Middleware;
using ShoppingApi.Data;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//Autofac 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder => { builder.RegisterModule(new AutoFacBusiness()); });

builder.Services.AddDbContext<ShoppingDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection")));

var ContainerBuilder = new ContainerBuilder();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());


//builder.Host.UseSerilog();
Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(builder.Configuration).CreateLogger();
Log.Information("Starting");

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Token>(builder.Configuration.GetSection("Token"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.ConfigureCustomExceptionMiddleware();

app.MapControllers();

app.Run();
