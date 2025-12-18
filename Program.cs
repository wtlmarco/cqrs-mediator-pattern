using Sample.Application.Abstractions;
using Sample.Application.Commands.Handlers;
using Sample.Application.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

//Sample 1: Traditional Service implementation
builder.Services.AddScoped<IProductService, PaymentService>();

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