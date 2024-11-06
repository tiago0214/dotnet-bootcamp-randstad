using Minimal_api.infrastructure.Db;
using Minimal_Api.Dominio.DTOs;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

builder.Services.AddDbContext<DbContexto>();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDto) =>
{
  Console.WriteLine(loginDto.Nome);

  if (loginDto.Email == "tiago0214" & loginDto.Senha == "123123")
  {
    return Results.Ok("login with success");
  }
  return Results.Unauthorized();
});

app.Run();
