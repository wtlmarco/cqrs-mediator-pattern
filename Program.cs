using Sample.Application.Abstractions;
using Sample.Application.Commands.Handlers;
using Sample.Application.Services;
using Sample.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddTransient<IOrderRepository, OrderRepository>();

//Sample 1: Traditional Service implementation
builder.Services.AddScoped<IProductService, ProductService>();

//Sample 2: Coding CQRS from Scratch
builder.Services.AddTransient<ICreateCustomerHandler, CreateCustomerHandler>();

//Sample 3: Implementation using Mediator (MediatR)
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();