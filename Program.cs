using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SchoolApiEntity;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddNpgsql<SchoolContext>(builder.Configuration.GetConnectionString("ConectionSchool"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/dbconection", async ([FromServices] SchoolContext dbContext) =>
{
    dbContext.Database.EnsureCreated();
    return Results.Ok("La base de datos ha sido creada: " + dbContext.Database.IsInMemory());
});

app.Run();
