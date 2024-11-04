var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (Minimal_Api.Dominio.DTOs.LoginDTO loginDto) =>
{
  Console.WriteLine(loginDto.Nome);
  
  if (loginDto.Email == "tiago0214" & loginDto.Senha == "123123")
  {
    return Results.Ok("login with success");
  }
  return Results.Unauthorized();
});

app.Run();
