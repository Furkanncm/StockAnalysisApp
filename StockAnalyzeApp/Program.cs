using FluentValidation.AspNetCore;
using Microsoft.Azure.Management.Sql.Fluent.Models;
using Microsoft.EntityFrameworkCore;
using Quartz.Impl;
using Quartz.Spi;
using Quartz;
using StockAnalyzeApp.Core.Repositories;
using StockAnalyzeApp.Core.Services;
using StockAnalyzeApp.Core.UnitOfWork;
using StockAnalyzeApp.Repository;
using StockAnalyzeApp.Repository.Repository;
using StockAnalyzeApp.Repository.UnitOfWork;
using StockAnalyzeApp.Service.Service;
using StockAnalyzeApp.Service.Validator.StockValidators;
using System.Reflection;
using System.Text.Json.Serialization;

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

// Quartz hizmetlerini ekleyin
builder.Services.AddSingleton<IJobFactory, SingletonJobFactory>();
builder.Services.AddSingleton<ISchedulerFactory, StdSchedulerFactory>();

// Quartz iþ ve trigger tanýmýný ekleyin
builder.Services.AddSingleton<StockCheckJob>();
builder.Services.AddSingleton(new JobSchedule(
    jobType: typeof(StockCheckJob),
    cronExpression: "0 0/1 * 1/1 * ? *" // Her sabah saat 09:00'da çalýþacak.
));

builder.Services.AddHostedService<QuartzHostedService>();
builder.Services.AddScoped<INotificationService, NotificationService>();
builder.Services.AddSingleton<StockCheckJob>(); // Quartz Job


builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IService<>), typeof(Service<>));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStockService, StockService>();
builder.Services.AddScoped<IStockRepository, StockRepository>();
builder.Services.AddScoped(typeof(StockAnalyzeAppContext));
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddScoped<ICompanyRepository, CompanyRepository>();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
