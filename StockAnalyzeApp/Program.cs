using FluentValidation.AspNetCore;
using Microsoft.Azure.Management.Sql.Fluent.Models;
using Microsoft.EntityFrameworkCore;
using Quartz.Impl;
using Quartz.Spi;
using Quartz;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using StockAnalyzeApp.Repository.Repository;
using StockAnalyzeApp.Repository.UnitOfWork;
using StockAnalyzeApp.Service.Service;
using StockAnalyzeApp.Service.Validator.StockValidators;
using System.Reflection;
using System.Text.Json.Serialization;
using StockAnalyzeApp.Repository.Context;
using Microsoft.Azure.Management.Storage.Fluent.Models;
using StockAnalyzeApp.Extensions;
using StockAnalyzeCache.CacheServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddFluentValidation(x=>x.RegisterValidatorsFromAssemblyContaining<StockAddDtoValidator>());
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(Assembly.GetAssembly(typeof(MapProfile)));


builder.Services.AddDbContext<StockAnalyzeAppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionString"), x =>
    {
        x.MigrationsAssembly(Assembly.GetAssembly(typeof(StockAnalyzeAppContext)).GetName().Name);
        Console.WriteLine("Connected");
    });
});

builder.Services.AddSingleton<IJobFactory, SingletonJobFactory>();
builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();

builder.Services.AddSingleton(new JobSchedule(
    jobType: typeof(StockCheckJob),
    cronExpression: "0 0 9 * * ?" //Every day at 9:00
));

builder.Services.AddHostedService<QuartzHostedService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddSingleton<StockCheckJob>(); // Quartz Job

builder.Services.AddScoped<FirebaseService>();
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserService, UserCacheService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStockService, StockCacheService>();
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped(typeof(StockAnalyzeAppContext));
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();
//builder.Services.Add(new ServiceDescriptor(typeof(IUserService), typeof(UserService)));

builder.Services.AddMemoryCache();


builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.ConfigureExceptionHandler();

app.UseAuthorization();

app.MapControllers();

app.Run();
