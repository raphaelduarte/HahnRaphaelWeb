using FluentAssertions.Common;
using System.Data;
using System.Collections.Generic;
using HahnRaphaelWeb;

using HahnRaphaelWeb.Infrastructure.Contexts;
using FluentValidation.AspNetCore;
using HahnRaphaelWeb.Domain;
using HahnRaphaelWeb.Domain.Commands;
using HahnRaphaelWeb.Domain.Commands.Contracts;
using HahnRaphaelWeb.Domain.Handlers;
using HahnRaphaelWeb.Domain.Repositories;
using HahnRaphaelWeb.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DataContext>(opt => opt.UseInMemoryDatabase("Database"));
builder.Services.AddControllers();
builder.Services.AddControllers()
    .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<CreateProductValidator>())
    .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<UpdateProductValidator>())
    .AddFluentValidation(config => config.RegisterValidatorsFromAssemblyContaining<RemoveProductValidator>());



builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<ProductHandler, ProductHandler>();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthentication();

app.UseAuthorization();

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.MapControllers();

app.Run();
