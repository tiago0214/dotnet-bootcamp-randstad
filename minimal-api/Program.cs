var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (Minimal_Api.Dominio.DTOs.LoginDTO loginDTO) =>
{
  Console.WriteLine(loginDTO.Nome);
  if (loginDTO.Email == "tiago0214" && loginDTO.Senha == "123123")
  {
    return Results.Ok("Login realizado com sucesso");
  }
  else
  {
    return Results.Unauthorized();
  }
});

app.Run();
