using BookStore.Catalog.Infrastructure;
using BookStore.Identity.Infrastructure;
using BookStore.Shared.Result;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentityModule().AddCatalogModule();

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/", () =>
{
    var response = Result.Success("Welcome to the BookStore API!");
    return Results.Ok(response);
});

app.Run();
