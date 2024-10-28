var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/login", (LoginDTO loginDTO) =>
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

class LoginDTO
{
  public string? Senha { get; set; }
  public string? Email { get; set; }
  public string? Nome { get; set; }
}